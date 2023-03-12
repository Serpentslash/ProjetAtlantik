using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class FormAjoutPort : Form
    {
        public FormAjoutPort()
        {
            InitializeComponent();
        }

        private void AjoutPortClick(object sender, EventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî-]{3,}$");
            var résultatTest = objetRegEx.Match(tbxPort.Text);

            if (!résultatTest.Success)
            {
                MessageBox.Show("Impossible", "Ajout échoué", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlConnection maCnx;
                MySqlDataReader jeuEnr = null;
                bool existant = false;

                //Vérification si le nom existe déjà
                maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
                try
                {
                    string requête;
                    maCnx.Open();

                    requête = "Select * from port";

                    var maCde = new MySqlCommand(requête, maCnx);

                    jeuEnr = maCde.ExecuteReader();
                    while (jeuEnr.Read())
                    {
                        if (jeuEnr["NOM"].ToString() == tbxPort.Text)
                        {
                            existant = true;
                            MessageBox.Show("Existant", "Ajout échoué", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
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


                if (existant == false)
                {
                    DialogResult retour;
                    retour = MessageBox.Show("Valider l'ajout d'un port ?", "La question",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                    if (retour == DialogResult.OK)
                    {
                        //Ajout du port dans la BDD port
                        jeuEnr = null;
                        maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
                        try
                        {
                            string requête;
                            maCnx.Open();
                            requête = "INSERT INTO port (NOM) VALUES(@NOM)";
                            var maCde = new MySqlCommand(requête, maCnx);
                            maCde.Parameters.AddWithValue("@NOM", tbxPort.Text);

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
                        MessageBox.Show(tbxPort.Text + " a bien été ajouter", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Annulation de l'ajout", "Ajout annuler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                this.Close();
            }
        }

        private void tbxPort_Validated(object sender, EventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî-]{3,}$");
            var résultatTest = objetRegEx.Match(tbxPort.Text);

            if (!résultatTest.Success)
            {
                tbxPort.BackColor = Color.Red;
            }
            else
            {
                tbxPort.BackColor = Color.White;
            }
        }
    }
}
