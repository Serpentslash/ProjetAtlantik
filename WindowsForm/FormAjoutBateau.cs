using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class FormAjoutBateau : Form
    {
        public FormAjoutBateau()
        {
            InitializeComponent();
        }

        private void AjoutBateau_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;

            //Ajout des catégories dans gbxCapaciteMax
            maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * FROM categorie";
                var maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();

                Label lbl;
                NumericUpDown nud;
                int i = 0;

                while (jeuEnr.Read())
                {
                    lbl = new Label();
                    lbl.Text = jeuEnr["LETTRECATEGORIE"].ToString() + " (" + jeuEnr["LIBELLE"].ToString() + "):";

                    lbl.Location = new Point(30, 50 + i * 40);
                    gbxCapaciteMax.Controls.Add(lbl);

                    nud = new NumericUpDown();
                    nud.Tag = jeuEnr["LETTRECATEGORIE"].ToString();
                    nud.Maximum = 2500;
                    nud.Minimum = 0;
                    nud.Size = new Size(120, 20);
                    nud.Validated += nud_Validated;

                    nud.Location = new Point(130, 50 + i * 40);
                    gbxCapaciteMax.Controls.Add(nud);

                    i += 1;
                }
            }
            catch (MySqlException error)
            {
                Console.WriteLine("Erreur " + error.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }

        //Ajout du bateau au click sur btnAjouter
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Boolean valide = true;

            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî-]{3,}$");
            var resultatTest = objetRegEx.Match(tbxNomBateau.Text);

            if (!resultatTest.Success)
            {
                tbxNomBateau.BackColor = Color.Red;
                valide = false;
            }

            foreach (NumericUpDown control in gbxCapaciteMax.Controls.OfType<NumericUpDown>())
            {
                if (control.Value == 0)
                {
                    control.BackColor = Color.Red;
                    valide = false;
                }
            }

            if (valide)
            {
                DialogResult retour;
                retour = MessageBox.Show("Valider l'ajout d'un bateau ?", "Validation",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (retour == DialogResult.OK)
                {
                    MySqlConnection maCnx;
                    bool existant = false;

                    //Vérification si le nom existe déjà
                    maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
                    try
                    {
                        string requête;
                        maCnx.Open();

                        requête = "Select * from bateau where nom = @nom";
                        var maCde = new MySqlCommand(requête, maCnx);
                        maCde.Parameters.AddWithValue("@NOM", tbxNomBateau.Text);

                        Int32 nbLignes = Convert.ToInt32(maCde.ExecuteScalar());

                        if (nbLignes != 0)
                        {
                            existant = true;
                            MessageBox.Show("Existant", "Ajout échoué", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (MySqlException error)
                    {
                        Console.WriteLine("Erreur " + error.ToString());
                    }
                    finally
                    {
                        if (maCnx is object & maCnx.State == ConnectionState.Open)
                        {
                            maCnx.Close();
                        }
                    }


                    if (existant == false)
                    {
                        long id = 0;
                        //Ajout du bateau dans la BDD bateau
                        maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
                        try
                        {
                            string requête;
                            maCnx.Open();
                            requête = "INSERT INTO bateau (NOM) VALUES(@NOM)";
                            var maCde = new MySqlCommand(requête, maCnx);
                            maCde.Parameters.AddWithValue("@NOM", tbxNomBateau.Text);

                            maCde.ExecuteNonQuery();
                            //(maCde.LastInsertedId);
                            id = maCde.LastInsertedId;

                        }
                        catch (MySqlException error)
                        {
                            Console.WriteLine("Erreur " + error.ToString());
                        }
                        finally
                        {
                            if (maCnx is object & maCnx.State == ConnectionState.Open)
                            {
                                maCnx.Close();
                            }
                        }

                        //Ajout du capaciteMax dans la BDD contenir
                        foreach (NumericUpDown control in gbxCapaciteMax.Controls.OfType<NumericUpDown>())
                        {
                            maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
                            try
                            {
                                string requête;
                                maCnx.Open();
                                requête = "INSERT INTO contenir (lettrecategorie, nobateau, capacitemax) VALUES(@lettrecategorie, @nobateau, @capacitemax)";
                                var maCde = new MySqlCommand(requête, maCnx);
                                maCde.Parameters.AddWithValue("@lettrecategorie", control.Tag);
                                maCde.Parameters.AddWithValue("@nobateau", id);
                                maCde.Parameters.AddWithValue("@capacitemax", control.Value);

                                maCde.ExecuteNonQuery();
                            }
                            catch (MySqlException error)
                            {
                                Console.WriteLine("Erreur " + error.ToString());
                            }
                            finally
                            {
                                if (maCnx is object & maCnx.State == ConnectionState.Open)
                                {
                                    maCnx.Close();
                                }
                            }
                        }
                        MessageBox.Show(tbxNomBateau.Text + " a bien été ajouter", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Annulation de l'ajout", "Ajout annuler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Veuillez à remplir tout les champs correctement", "Ajout échoué", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Vérification Form
        private void tbxNomBateau_Validated(object sender, EventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî-]{3,}$");
            var résultatTest = objetRegEx.Match(tbxNomBateau.Text);

            if (!résultatTest.Success)
            {
                tbxNomBateau.BackColor = Color.Red;
            }
            else
            {
                tbxNomBateau.BackColor = Color.White;
            }
        }


        private void nud_Validated(object sender, EventArgs e)
        {
            if (((NumericUpDown)(sender)).Value == 0)
            {
                ((NumericUpDown)(sender)).BackColor = Color.Red;
            }
            else
            {
                ((NumericUpDown)(sender)).BackColor = Color.White;
            }
        }
    }
}
