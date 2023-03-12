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
    public partial class FormAfficherDetails : Form
    {
        public FormAfficherDetails()
        {
            InitializeComponent();
        }

        private void FormAfficherDetails_Load(object sender, EventArgs e)
        {
            lvReservations.View = View.Details;
            lvReservations.GridLines = true;
            lvReservations.FullRowSelect = true;
            //lvReservations.MultiSelect = false;

            lvReservations.Columns.Add("n°Réservation", lvReservations.Width/4-1);
            lvReservations.Columns.Add("Liaison", lvReservations.Width / 4 - 1);
            lvReservations.Columns.Add("n°Traversée", lvReservations.Width / 4 - 1);
            lvReservations.Columns.Add("Date départ", lvReservations.Width / 4 - 1);

            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;

            //Ajout client dans cmbNomPrenom
            maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * FROM client";
                var maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbClient.Items.Add(new Client((int)jeuEnr["noclient"], jeuEnr["nom"].ToString(), jeuEnr["prenom"].ToString()));
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

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvReservations.Items.Clear();
            if((Client)cmbClient.SelectedItem !=null)
            {
                MySqlConnection maCnx;
                MySqlDataReader jeuEnr = null;

                //Ajout client dans cmbNomPrenom
                maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
                try
                {
                    string requête;
                    maCnx.Open();
                    requête = "SELECT noreservation, r.notraversee, dateheuredepart, D.NOM AS NOMPORT_DEPART, A.NOM AS NOMPORT_ARRIVEE FROM reservation r, traversee t, liaison l INNER JOIN port D ON l.NOPORT_DEPART = D.NOPORT INNER JOIN port A ON l.NOPORT_ARRIVEE = A.NOPORT WHERE NOCLIENT = @noclient AND r.notraversee = t.notraversee AND t.NOLIAISON = l.noliaison;";
                    var maCde = new MySqlCommand(requête, maCnx);
                    maCde.Parameters.AddWithValue("@noclient", ((Client)cmbClient.SelectedItem).GetNoClient());

                    jeuEnr = maCde.ExecuteReader();

                    var tabItem = new string[5];
                    ListViewItem unItem;

                    while (jeuEnr.Read())
                    {
                        tabItem[0] = jeuEnr["noreservation"].ToString();
                        tabItem[1] = jeuEnr["NOMPORT_DEPART"].ToString() + " - " + jeuEnr["NOMPORT_ARRIVEE"].ToString();
                        tabItem[2] = jeuEnr["notraversee"].ToString();
                        tabItem[3] = jeuEnr["dateheuredepart"].ToString();

                        unItem = new ListViewItem(tabItem);
                        lvReservations.Items.Add(unItem);
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

        private void lvReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvReservations.SelectedItems != null & lvReservations.SelectedItems.Count == 1)
            {
                gbxDetailsReservation.Controls.Clear();
                MySqlConnection maCnx;
                MySqlDataReader jeuEnr = null;

                //Ajout libelle et quantite dans gbxDetailsReservation
                maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
                try
                {
                    string requête;
                    maCnx.Open();
                    requête = "SELECT libelle, QUANTITERESERVEE, montanttotal, modereglement FROM type t, enregistrer e, reservation r WHERE t.LETTRECATEGORIE = e.LETTRECATEGORIE and t.NOTYPE = e.NOTYPE AND r.NORESERVATION = e.NORESERVATION AND e.NORESERVATION = @noreservation;";
                    var maCde = new MySqlCommand(requête, maCnx);
                    string id = lvReservations.SelectedItems[0].SubItems[0].Text;
                    maCde.Parameters.AddWithValue("@noreservation", id);

                    jeuEnr = maCde.ExecuteReader();

                    Label lbl;
                    int i = 0;

                    while (jeuEnr.Read())
                    {
                        lbl = new Label();
                        lbl.Text = jeuEnr["libelle"].ToString() + " : " + jeuEnr["QUANTITERESERVEE"].ToString();
                        lbl.Size = new Size(200, 20);

                        lbl.Location = new Point(30, 40 + i * 25);
                        gbxDetailsReservation.Controls.Add(lbl);
                        i += 1;
                    }

                    lbl = new Label();
                    lbl.Text = "Montant total : " + jeuEnr["montanttotal"].ToString() + "€";
                    lbl.Size = new Size(200, 20);

                    lbl.Location = new Point(30, 40 + i * 25);
                    gbxDetailsReservation.Controls.Add(lbl);
                    i += 1;

                    lbl = new Label();
                    lbl.Text = "Réglé par : " + jeuEnr["modereglement"].ToString();
                    lbl.Size = new Size(200, 20);

                    lbl.Location = new Point(30, 40 + i * 25);
                    gbxDetailsReservation.Controls.Add(lbl);
                    i += 1;
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
