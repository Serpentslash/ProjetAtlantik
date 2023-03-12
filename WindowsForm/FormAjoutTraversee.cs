using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class FormAjoutTraversee : Form
    {
        public FormAjoutTraversee()
        {
            InitializeComponent();
        }


        private void AjoutTraversee_Load(object sender, EventArgs e)
        {
            dateDepart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day+7);
            dateArrivee.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day+7);
            //int year, int month, int day, int hour, int minute, int second
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

            //Ajout bateau dans cmbBateau
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
        }


        private void lbxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLiaison.Items.Clear();

            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;

            //Ajout liaison dans cmbLiaison
            if ((Secteur)lbxSecteur.SelectedItem != null)
            {
                maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
                try
                {
                    string requête;
                    maCnx.Open();
                    requête = "SELECT l.NOLIAISON, l.NOPORT_DEPART, l.NOSECTEUR, l.NOPORT_ARRIVEE, l.DISTANCE, D.NOM AS NOMPORT_DEPART, A.NOM AS NOMPORT_ARRIVEE FROM liaison l INNER JOIN port D ON l.NOPORT_DEPART = D.NOPORT INNER JOIN port A ON l.NOPORT_ARRIVEE = A.NOPORT WHERE NOSECTEUR = @NOSECTEUR";
                    var maCde = new MySqlCommand(requête, maCnx);
                    maCde.Parameters.AddWithValue("@NOSECTEUR", ((Secteur)lbxSecteur.SelectedItem).GetNoSecteur());

                    jeuEnr = maCde.ExecuteReader();
                    while (jeuEnr.Read())
                    {
                        cmbLiaison.Items.Add(new Liaison((int)jeuEnr["NOLIAISON"], (int)jeuEnr["NOPORT_DEPART"], (int)jeuEnr["NOSECTEUR"], (int)jeuEnr["NOPORT_ARRIVEE"], (double)jeuEnr["DISTANCE"], jeuEnr["NOMPORT_DEPART"].ToString(), jeuEnr["NOMPORT_ARRIVEE"].ToString()));
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
        }


        private void btnAjout_Click(object sender, EventArgs e)
        {
            Boolean valide = true;

            if ((Secteur)lbxSecteur.SelectedItem == null)
            {
                lbxSecteur.BackColor = Color.Red;
                valide = false;
            }

            if ((Liaison)cmbLiaison.SelectedItem == null)
            {
                cmbLiaison.BackColor = Color.Red;
                valide = false;
            }

            if ((Bateau)cmbBateau.SelectedItem == null)
            {
                cmbBateau.BackColor = Color.Red;
                valide = false;
            }

            DateTime dateheuredepart = Convert.ToDateTime(dateDepart.Value);

            if (dateheuredepart < DateTime.Now)
            {
                lblDateHeureDepart.Visible = true;
                valide = false;
            }

            DateTime dateheurearrivee = Convert.ToDateTime(dateArrivee.Value);

            if (dateheuredepart > dateheurearrivee)
            {
                lblErreurArrivee.Visible = true;
                valide = false;
            }

            if (valide)
            {
                DialogResult retour;
                retour = MessageBox.Show("Valider l'ajout d'une traversée ?", "Validation",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (retour == DialogResult.OK)
                {
                    MySqlConnection maCnx;

                    //Ajout traversee dans BDD traversee
                    maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
                    try
                    {
                        string requête;
                        maCnx.Open();
                        requête = "INSERT INTO traversee (noliaison, nobateau, dateheuredepart, dateheurearrivee) VALUES(@noliaison, @nobateau, @dateheuredepart, @dateheurearrivee)";
                        var maCde = new MySqlCommand(requête, maCnx);

                        maCde.Parameters.AddWithValue("@noliaison", ((Liaison)cmbLiaison.SelectedItem).GetNoLiaison());
                        maCde.Parameters.AddWithValue("@nobateau", ((Bateau)cmbBateau.SelectedItem).GetNoBateau());
                        maCde.Parameters.AddWithValue("@dateheuredepart", dateheuredepart);
                        maCde.Parameters.AddWithValue("@dateheurearrivee", dateheurearrivee);

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
                    MessageBox.Show("La traversée a bien été ajouter", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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


        //Verification
        private void dateDepart_Validated(object sender, EventArgs e)
        {
            DateTime dateetheuredepart = Convert.ToDateTime(dateDepart.Value);
            if (dateetheuredepart < DateTime.Now)
            {
                lblErreurDepart.Visible = true;
            }
            else
            {
                lblErreurDepart.Visible = false;
            }
        }

        private void dateArrivee_Validated(object sender, EventArgs e)
        {
            DateTime dateetheuredepart = Convert.ToDateTime(dateDepart.Value);
            DateTime dateetheurearrivee = Convert.ToDateTime(dateArrivee.Value);

            if (dateetheuredepart > dateetheurearrivee)
            {
                lblErreurArrivee.Visible = true;
            }
            else
            {
                lblErreurArrivee.Visible = false;
            }
        }


        private void lbxSecteur_Validated(object sender, EventArgs e)
        {
            if ((Secteur)lbxSecteur.SelectedItem == null)
            {
                lbxSecteur.BackColor = Color.Red;
            }
            else
            {
                lbxSecteur.BackColor = Color.White;
            }
        }


        private void cmbLiaison_Validated(object sender, EventArgs e)
        {
            if ((Liaison)cmbLiaison.SelectedItem == null)
            {
                cmbLiaison.BackColor = Color.Red;
            }
            else
            {
                cmbLiaison.BackColor = Color.White;
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
