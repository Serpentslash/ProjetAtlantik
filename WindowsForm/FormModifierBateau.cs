using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using Google.Protobuf.WellKnownTypes;

namespace WindowsForm
{
    public partial class FormModifierBateau : Form
    {
        public FormModifierBateau()
        {
            InitializeComponent();
        }

        private void ModifierBateau_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;

            //Ajout des bateaux dans cmbBateau
            maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * FROM bateau";
                var maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    cmbBateau.Items.Add(new Bateau(jeuEnr["nom"].ToString(), (int)jeuEnr["nobateau"]));
                }
            }
            catch (MySqlException error)
            {
                Console.WriteLine("Erreur " + error.ToString());
            }
            finally
            {
                if (jeuEnr is object & !jeuEnr.IsClosed)
                {
                    jeuEnr.Close();
                }
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }

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
                    nud.Size = new Size(120, 20);
                    nud.Maximum = 2500;
                    nud.Minimum = 0;
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
                if (jeuEnr is object & !jeuEnr.IsClosed)
                {
                    jeuEnr.Close();
                }
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }


        //Ajout capaciteMAX à gbxCapaciteMax du bateau selectionner
        private void cmbBateau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Bateau)cmbBateau.SelectedItem != null)
            {
                MySqlConnection maCnx;
                MySqlDataReader jeuEnr = null;

                foreach (NumericUpDown control in gbxCapaciteMax.Controls.OfType<NumericUpDown>())
                {
                    maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
                    try
                    {
                        string requête;
                        maCnx.Open();
                        requête = "select * from contenir where nobateau = @nobateau and lettrecategorie = @lettrecategorie";
                        var maCde = new MySqlCommand(requête, maCnx);
                        maCde.Parameters.AddWithValue("@nobateau", ((Bateau)cmbBateau.SelectedItem).GetNoBateau());
                        maCde.Parameters.AddWithValue("@lettrecategorie", control.Tag.ToString());

                        jeuEnr = maCde.ExecuteReader();

                        jeuEnr.Read();

                        control.Value = (int)jeuEnr["capacitemax"];

                    }
                    catch (MySqlException error)
                    {
                        Console.WriteLine("Erreur " + error.ToString());
                    }
                    finally
                    {
                        if (jeuEnr is object & !jeuEnr.IsClosed)
                        {
                            jeuEnr.Close();
                        }
                        if (maCnx is object & maCnx.State == ConnectionState.Open)
                        {
                            maCnx.Close();
                        }
                    }
                }
            }
        }

        //Modification ligne
        private void btnModifier_Click(object sender, EventArgs e)
        {
            Boolean valide = true;

            foreach (NumericUpDown control in gbxCapaciteMax.Controls.OfType<NumericUpDown>())
            {
                if (control.Value == 0)
                {
                    control.BackColor = Color.Red;
                    valide = false;
                }
            }

            if ((Bateau)cmbBateau.SelectedItem == null)
            {
                cmbBateau.BackColor = Color.Red;
                valide = false;
            }

            if (valide)
            {
                DialogResult retour;
                retour = MessageBox.Show("Valider la modification du bateau ?", "Validation",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (retour == DialogResult.OK)
                {
                    MySqlConnection maCnx;

                    //Modification des capaciteMax dans la BDD contenir
                    foreach (NumericUpDown control in gbxCapaciteMax.Controls.OfType<NumericUpDown>())
                    {
                        maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
                        try
                        {
                            string requête;
                            maCnx.Open();
                            requête = "UPDATE contenir SET CAPACITEMAX = @capacitemax WHERE nobateau = @nobateau and LETTRECATEGORIE = @lettrecategorie";
                            var maCde = new MySqlCommand(requête, maCnx);
                            maCde.Parameters.AddWithValue("@lettrecategorie", control.Tag);
                            maCde.Parameters.AddWithValue("@capacitemax", control.Value);
                            maCde.Parameters.AddWithValue("@nobateau", ((Bateau)cmbBateau.SelectedItem).GetNoBateau());

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
                    MessageBox.Show(((Bateau)cmbBateau.SelectedItem).ToString() + " a bien été modifier", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Annulation de l'ajout", "Ajout annuler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Veuillez à remplir tout les champs", "Modification échoué", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Verification formulaire valide

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

        private void cmbBateau_Validated(object sender, EventArgs e)
        {
            if ((Bateau)cmbBateau.SelectedItem == null)
            {
                cmbBateau.BackColor = Color.Red;
            }
            else
            {
                cmbBateau.BackColor = Color.White;
            }
        }
    }
}
