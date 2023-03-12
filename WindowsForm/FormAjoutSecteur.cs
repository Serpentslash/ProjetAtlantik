using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace WindowsForm
{
    public partial class FormAjoutSecteur : Form
    {
        public FormAjoutSecteur()
        {
            InitializeComponent();
        }


        private void AjoutSecteurClick(object sender, EventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî-]{3,}$");
            var resultatTest = objetRegEx.Match(tbxSecteur.Text);

            if (!resultatTest.Success)
            {
                MessageBox.Show("Impossible", "Ajout échoué", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlConnection maCnx;
                MySqlDataReader jeuEnr = null;
                bool existant = false;

                maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
                try
                {
                    string requête;
                    maCnx.Open();

                    requête = "Select * from secteur";

                    var maCde = new MySqlCommand(requête, maCnx);

                    jeuEnr = maCde.ExecuteReader();
                    while (jeuEnr.Read())
                    {
                        if (jeuEnr["NOM"].ToString() == tbxSecteur.Text)
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
                    retour = MessageBox.Show("Valider l'ajout d'un secteur ?", "La question",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                    if (retour == DialogResult.OK)
                    {
                        //Ajout dans base
                        jeuEnr = null;
                        maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
                        try
                        {
                            string requête;
                            maCnx.Open();
                            requête = "INSERT INTO secteur (NOM) VALUES(@NOM)";
                            var maCde = new MySqlCommand(requête, maCnx);
                            maCde.Parameters.AddWithValue("@NOM", tbxSecteur.Text);

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
                        MessageBox.Show(tbxSecteur.Text + " a bien été ajouter", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Annulation de l'ajout", "Ajout annuler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                this.Close();
            }
        }

        private void tbxSecteur_Validated(object sender, EventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî-]{3,}$");
            var résultatTest = objetRegEx.Match(tbxSecteur.Text);

            if (!résultatTest.Success)
            {
                tbxSecteur.BackColor = Color.Red;
            }
            else
            {
                tbxSecteur.BackColor = Color.White;
            }
        }
    }
}
