using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class FormAfficherTraversees : Form
    {
        public FormAfficherTraversees()
        {
            InitializeComponent();
        }

        private void FormAfficherTraversees_Load(object sender, EventArgs e)
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

            lvTraversees.View = View.Details;
            lvTraversees.GridLines = true;
            lvTraversees.FullRowSelect = true;

            lvTraversees.Columns.Add("N°", lvTraversees.Width / 9);
            lvTraversees.Columns.Add("Heure", lvTraversees.Width / 9);
            lvTraversees.Columns.Add("Bateau", lvTraversees.Width / 9);

            //Ajout secteur dans lbxSecteur
            maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * FROM categorie";
                var maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    int width = (lvTraversees.Width - lvTraversees.Width / 3) / 3;
                    lvTraversees.Columns.Add(jeuEnr["lettrecategorie"].ToString() + "   " + jeuEnr["libelle"].ToString(), width);
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

            //dateTraversee.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 7);
            dateTraversee.Value = new DateTime(2021, 07, 10);
        }

        private void lbxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLiaison.Items.Clear();

            if ((Secteur)lbxSecteur.SelectedItem != null)
            {
                MySqlConnection maCnx;
                MySqlDataReader jeuEnr = null;

                //Ajout liaison dans cmbLiaison
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

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MySqlConnection maCnx;
                MySqlDataReader jeuEnr = null;

                maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
                try
                {
                    string requête;
                    maCnx.Open();
                    requête = "SELECT *  FROM traversee t, bateau b WHERE noliaison = @noliaison AND dateheuredepart LIKE @datetraversee AND t.NOBATEAU = b.NOBATEAU ORDER BY NOTRAVERSEE";
                    var maCde = new MySqlCommand(requête, maCnx);
                    maCde.Parameters.AddWithValue("@noliaison", ((Liaison)cmbLiaison.SelectedItem).GetNoLiaison());

                    DateTime date = new DateTime(dateTraversee.Value.Year, dateTraversee.Value.Month, dateTraversee.Value.Day);
                    maCde.Parameters.AddWithValue("@datetraversee", date.ToString("yyyy-MM-dd") + "%");

                    jeuEnr = maCde.ExecuteReader();

                    var tabItem = new string[7];
                    ListViewItem unItem;

                    while (jeuEnr.Read())
                    {
                        string heure = jeuEnr["dateheuredepart"].ToString().Split(' ')[1];

                        tabItem[0] = jeuEnr["notraversee"].ToString();
                        tabItem[1] = heure.Split(':')[0] + ":" + heure.Split(':')[1];

                        tabItem[2] = jeuEnr["nom"].ToString();

                        tabItem[3] = jeuEnr["notraversee"].ToString();
                        tabItem[4] = jeuEnr["notraversee"].ToString();
                        tabItem[5] = jeuEnr["notraversee"].ToString();

                        unItem = new ListViewItem(tabItem);
                        lvTraversees.Items.Add(unItem);
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
    }
}
