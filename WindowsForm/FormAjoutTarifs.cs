using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class FormAjoutTarifs : Form
    {
        public FormAjoutTarifs()
        {
            InitializeComponent();
        }

        private void AjoutTarifs_Load(object sender, EventArgs e)
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

            //Ajout des périodes dans cmbPeriode
            maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * FROM periode";
                var maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbPeriode.Items.Add(new Periode((short)jeuEnr["NOPERIODE"], jeuEnr["DATEDEBUT"].ToString(), jeuEnr["DATEFIN"].ToString()));

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

            //Ajout des types dans gbxTarifs
            maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * FROM type";
                var maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();

                Label lbl;
                NumericUpDown nud;
                int i = 0;

                while (jeuEnr.Read())
                {
                    lbl = new Label();
                    lbl.Text = jeuEnr["LETTRECATEGORIE"].ToString() + jeuEnr["NOTYPE"].ToString() + " - " + jeuEnr["LIBELLE"].ToString() + " :";

                    lbl.Location = new Point(30, 30 + i * 25);
                    gbxTarifs.Controls.Add(lbl);

                    nud = new NumericUpDown();
                    nud.Tag = jeuEnr["LETTRECATEGORIE"].ToString() + ";" + jeuEnr["NOTYPE"].ToString();
                    nud.Size = new Size(120, 20);
                    nud.Maximum = 2500;
                    nud.Minimum = 0;
                    nud.DecimalPlaces = 2;
                    nud.Validated += nud_Validated;

                    nud.Location = new Point(130, 30 + i * 25);
                    gbxTarifs.Controls.Add(nud);

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

            //Verification formulaire valide
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

            if ((Periode)cmbPeriode.SelectedItem == null)
            {
                cmbPeriode.BackColor = Color.Red;
                valide = false;
            }

            foreach (NumericUpDown control in gbxTarifs.Controls.OfType<NumericUpDown>())
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
                retour = MessageBox.Show("Valider l'ajout d'une traversée ?", "Validation",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (retour == DialogResult.OK)
                {
                    foreach (NumericUpDown control in gbxTarifs.Controls.OfType<NumericUpDown>())
                    {
                        MySqlConnection maCnx;

                        //Ajout tarifs dans BDD tarifier
                        maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
                        try
                        {
                            string requête;
                            maCnx.Open();
                            requête = "INSERT INTO tarifer (noperiode, lettrecategorie, notype, noliaison, tarif) VALUES(@noperiode, @lettrecategorie, @notype, @noliaison, @tarif)";
                            var maCde = new MySqlCommand(requête, maCnx);

                            maCde.Parameters.AddWithValue("@noperiode", ((Periode)cmbPeriode.SelectedItem).GetNoPeriode());
                            maCde.Parameters.AddWithValue("@lettrecategorie", control.Tag.ToString().Split(';')[0]);
                            maCde.Parameters.AddWithValue("@notype", control.Tag.ToString().Split(';')[1]);
                            maCde.Parameters.AddWithValue("@noliaison", ((Liaison)cmbLiaison.SelectedItem).GetNoLiaison());
                            maCde.Parameters.AddWithValue("@tarif", control.Value);

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
                    MessageBox.Show("Les tarifs ont bien été ajouter", "Ajout réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cmbPeriode_Validated(object sender, EventArgs e)
        {
            if ((Periode)cmbPeriode.SelectedItem == null)
            {
                cmbPeriode.BackColor = Color.Red;
            }
            else
            {
                cmbPeriode.BackColor = Color.White;
            }
        }
    }
}
