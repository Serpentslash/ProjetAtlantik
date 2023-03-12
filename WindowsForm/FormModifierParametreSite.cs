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
    public partial class FormModifierParametreSite : Form
    {
        public FormModifierParametreSite()
        {
            InitializeComponent();
        }

        private void FormModifierParametreSite_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;

            //Remplissage avec valeur de la BDD parametres
            maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * FROM parametres";
                var maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    tbxSite.Text = jeuEnr["site_pb"].ToString();
                    tbxRang.Text = jeuEnr["rang_pb"].ToString();
                    tbxIdentifiant.Text = jeuEnr["identifiant_pb"].ToString();
                    tbxCleHMAC.Text = jeuEnr["clehmac_pb"].ToString();
                    tbxMelSite.Text = jeuEnr["melsite"].ToString();
                     cbxEnProduction.Checked = (bool)jeuEnr["enproduction"];
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

        private void btnModifier_Click(object sender, EventArgs e)
        {
            DialogResult retour;
            retour = MessageBox.Show("Valider la modification du site ?", "Validation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (retour == DialogResult.OK)
            {
                MySqlConnection maCnx;

                //Modification
                maCnx = new MySqlConnection("server=localhost;user=root;database=projetatlantik;port=3306;password=");
                try
                {
                    string requête;
                    maCnx.Open();
                    requête = "UPDATE parametres SET site_pb = @site_pb, rang_pb = @rang_pb, identifiant_pb = @identifiant_pb, clehmac_pb = @clehmac_pb, melsite = @melsite, enproduction = @enproduction";
                    var maCde = new MySqlCommand(requête, maCnx);
                    maCde.Parameters.AddWithValue("@site_pb", tbxSite.Text);
                    maCde.Parameters.AddWithValue("@rang_pb", tbxRang.Text);
                    maCde.Parameters.AddWithValue("@identifiant_pb", tbxIdentifiant.Text);
                    maCde.Parameters.AddWithValue("@clehmac_pb", tbxCleHMAC.Text);
                    maCde.Parameters.AddWithValue("@melsite", tbxMelSite.Text);
                    maCde.Parameters.AddWithValue("@enproduction", cbxEnProduction.Checked);

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

        
    }
}
