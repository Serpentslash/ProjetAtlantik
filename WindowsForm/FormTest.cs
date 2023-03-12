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
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            lvProduits.View = View.Details; // Mode d'affichage

            // (on peut également afficher sous forme de petites icônes etc...)

            lvProduits.GridLines = true; // on affichera la grille

            lvProduits.FullRowSelect = true; // Mode de sélection : ligne

            // Pour le mode de selection voir aussi la property SelectionMode



            // Ajout des entêtes de colonne

            lvProduits.Columns.Add("nomDuProduit", 100); // 100 = largeur colonne

            lvProduits.Columns.Add("prix", 70);

            lvProduits.Columns.Add("quantité", 70);



            // Ajout de 2 lignes dans le Listview

            var tabItem = new string[4];

            ListViewItem unItem;



            // Ajout d'un premier item

            tabItem[0] = "Produit1";

            tabItem[1] = "100";

            tabItem[2] = "10";

            unItem = new ListViewItem(tabItem); // Création ligne

            lvProduits.Items.Add(unItem); // Ajout ligne



            // Ajout d'un second item

            tabItem[0] = "Produit2";

            tabItem[1] = "200";

            tabItem[2] = "20";

            lvProduits.Items.Add(new ListViewItem(tabItem));
        }

        private void btnOk_Click(object sender, EventArgs e)
        {     
            string nomDuProduit, prix, quantité;

            nomDuProduit = lvProduits.SelectedItems[0].SubItems[0].Text;

            prix = lvProduits.SelectedItems[0].SubItems[1].Text;

            quantité = lvProduits.SelectedItems[0].SubItems[2].Text;

            // SelectedItemS : on peut sélectionner, plusieurs lignes

            // Si l'on sélectionne les 2 lignes : Item(0) = Ligne 1, Item(1) = Ligne 2

            // (mode de sélection ligne)

            // SubItems(1) = colonne 1...

            MessageBox.Show(nomDuProduit + " , " + prix + " , " + quantité);

            
        }
    }
}
