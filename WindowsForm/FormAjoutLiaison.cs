using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsForm
{
    public partial class FormAjoutLiaison : Form
    {
        public FormAjoutLiaison()
        {
            InitializeComponent();
        }

        private void AjoutLiaison_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;

            //Ajout secteur dans lbxSecteur
            maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * FROM secteur";
                var maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    lbxSecteur.Items.Add(new Secteur(jeuEnr["nom"].ToString(), (int)jeuEnr["nosecteur"]));
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

            //Ajout port dans cmbPortDepart et cmbPortArrivee
            jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * FROM port";
                var maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbPortDepart.Items.Add(new Port(jeuEnr["nom"].ToString(), (int)jeuEnr["noport"]));
                    cmbPortArrivee.Items.Add(new Port(jeuEnr["nom"].ToString(), (int)jeuEnr["noport"]));
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Boolean valide = true;

            //Verification
            if ((Secteur)lbxSecteur.SelectedItem == null)
            {
                lbxSecteur.BackColor = Color.Red;
                valide = false;
            }

            if ((Port)cmbPortDepart.SelectedItem == null)
            {
                cmbPortDepart.BackColor = Color.Red;
                valide = false;
            }

            if ((Port)cmbPortArrivee.SelectedItem == null)
            {
                cmbPortArrivee.BackColor = Color.Red;
                valide = false;
            }

            if (nudDistance.Value <= 0)
            {
                nudDistance.BackColor = Color.Red;
                valide = false;
            }

            if (valide)   
            {
                DialogResult retour;
                retour = MessageBox.Show("Valider l'ajout d'une liaison ?", "Validation",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (retour == DialogResult.OK)
                {
                    MySqlConnection maCnx;

                    //Ajout de la liaison à la base de données
                    maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
                    try
                    {
                        string requête;
                        maCnx.Open();
                        requête = "INSERT INTO liaison (NOPORT_DEPART, NOSECTEUR, NOPORT_ARRIVEE, DISTANCE) VALUES(@NOPORT_DEPART, @NOSECTEUR, @NOPORT_ARRIVEE, @DISTANCE)";
                        var maCde = new MySqlCommand(requête, maCnx);
                        maCde.Parameters.AddWithValue("@NOPORT_DEPART", ((Port)cmbPortDepart.SelectedItem).GetNoPort());
                        maCde.Parameters.AddWithValue("@NOSECTEUR", ((Secteur)lbxSecteur.SelectedItem).GetNoSecteur());
                        maCde.Parameters.AddWithValue("@NOPORT_ARRIVEE", ((Port)cmbPortArrivee.SelectedItem).GetNoPort());
                        maCde.Parameters.AddWithValue("@DISTANCE", nudDistance.Value);

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
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Annulation de l'ajout", "Ajout annulé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Veuillez à remplir tout les champs", "Ajout échoué", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Verification
        private void lbxSecteur_Validated(object sender, EventArgs e)
        {
            if((Secteur)lbxSecteur.SelectedItem == null)
            {
                lbxSecteur.BackColor = Color.Red;
            }
            else
            {
                lbxSecteur.BackColor = Color.White;
            }
        }

        private void cmbPortDepart_Validated(object sender, EventArgs e)
        {
            if ((Port)cmbPortDepart.SelectedItem == null)
            {
                cmbPortDepart.BackColor = Color.Red;
            }
            else
            {
                cmbPortDepart.BackColor = Color.White;
            }
        }

        private void cmbPortArrivee_Validated(object sender, EventArgs e)
        {
            if ((Port)cmbPortArrivee.SelectedItem == null)
            {
                cmbPortArrivee.BackColor = Color.Red;
            }
            else
            {
                cmbPortArrivee.BackColor = Color.White;
            }
        }

        private void nudDistance_Validated(object sender, EventArgs e)
        {
            if(nudDistance.Value <= 0)
            {
                nudDistance.BackColor= Color.Red;
            }
            else
            {
                nudDistance.BackColor= Color.White;
            }
        }
    }
}
