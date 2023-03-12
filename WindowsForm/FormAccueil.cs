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
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }

        //Menu
        private void miABateau_Click(object sender, EventArgs e)
        {
            FormAjoutBateau formNouvelle = new FormAjoutBateau();
            formNouvelle.ShowDialog();
        }

        private void miSecteur_Click(object sender, EventArgs e)
        {
            FormAjoutSecteur formNouvelle = new FormAjoutSecteur();
            formNouvelle.ShowDialog();
        }

        private void miPort_Click(object sender, EventArgs e)
        {
            FormAjoutPort formNouvelle = new FormAjoutPort();
            formNouvelle.ShowDialog();
        }

        private void miLiaison_Click(object sender, EventArgs e)
        {
            FormAjoutLiaison formNouvelle = new FormAjoutLiaison();
            formNouvelle.ShowDialog();
        }

        private void miTarifs_Click(object sender, EventArgs e)
        {
            FormAjoutTarifs formNouvelle = new FormAjoutTarifs();
            formNouvelle.ShowDialog();
        }

        private void miMBateau_Click(object sender, EventArgs e)
        {
            FormModifierBateau formNouvelle = new FormModifierBateau();
            formNouvelle.ShowDialog();
        }

        private void miAjouterTraversee_Click(object sender, EventArgs e)
        {
            FormAjoutTraversee formNouvelle = new FormAjoutTraversee();
            formNouvelle.ShowDialog();
        }

        private void customInstaller1_AfterInstall(object sender, System.Configuration.Install.InstallEventArgs e)
        {

        }

        private void miParametresSite_Click(object sender, EventArgs e)
        {
            FormModifierParametreSite formNouvelle = new FormModifierParametreSite();
            formNouvelle.ShowDialog();
        }

        private void miAfficherTraversee_Click(object sender, EventArgs e)
        {
            FormAfficherTraversees formNouvelle = new FormAfficherTraversees();
            formNouvelle.ShowDialog();
        }

        private void miDetails_Click(object sender, EventArgs e)
        {
            FormAfficherDetails formNouvelle = new FormAfficherDetails();
            formNouvelle.ShowDialog();
        }
    }
}
