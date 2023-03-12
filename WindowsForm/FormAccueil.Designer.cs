namespace WindowsForm
{
    partial class FormAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.mmAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.miSecteur = new System.Windows.Forms.ToolStripMenuItem();
            this.miPort = new System.Windows.Forms.ToolStripMenuItem();
            this.miLiaison = new System.Windows.Forms.ToolStripMenuItem();
            this.miTarifs = new System.Windows.Forms.ToolStripMenuItem();
            this.miABateau = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterTraversee = new System.Windows.Forms.ToolStripMenuItem();
            this.mmModifier = new System.Windows.Forms.ToolStripMenuItem();
            this.miMBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.miParametresSite = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.miAfficherTraversee = new System.Windows.Forms.ToolStripMenuItem();
            this.miDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmAjouter,
            this.mmModifier,
            this.mmAfficher,
            this.mmAPropos});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(800, 24);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "msPrincipal";
            // 
            // mmAjouter
            // 
            this.mmAjouter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSecteur,
            this.miPort,
            this.miLiaison,
            this.miTarifs,
            this.miABateau,
            this.miAjouterTraversee});
            this.mmAjouter.Name = "mmAjouter";
            this.mmAjouter.Size = new System.Drawing.Size(58, 20);
            this.mmAjouter.Text = "Ajouter";
            // 
            // miSecteur
            // 
            this.miSecteur.Name = "miSecteur";
            this.miSecteur.Size = new System.Drawing.Size(287, 22);
            this.miSecteur.Text = "Un secteur";
            this.miSecteur.Click += new System.EventHandler(this.miSecteur_Click);
            // 
            // miPort
            // 
            this.miPort.Name = "miPort";
            this.miPort.Size = new System.Drawing.Size(287, 22);
            this.miPort.Text = "Un port";
            this.miPort.Click += new System.EventHandler(this.miPort_Click);
            // 
            // miLiaison
            // 
            this.miLiaison.Name = "miLiaison";
            this.miLiaison.Size = new System.Drawing.Size(287, 22);
            this.miLiaison.Text = "Une liaison";
            this.miLiaison.Click += new System.EventHandler(this.miLiaison_Click);
            // 
            // miTarifs
            // 
            this.miTarifs.Name = "miTarifs";
            this.miTarifs.Size = new System.Drawing.Size(287, 22);
            this.miTarifs.Text = "Les tarifs pour une liaison et une période";
            this.miTarifs.Click += new System.EventHandler(this.miTarifs_Click);
            // 
            // miABateau
            // 
            this.miABateau.Name = "miABateau";
            this.miABateau.Size = new System.Drawing.Size(287, 22);
            this.miABateau.Text = "Un bateau";
            this.miABateau.Click += new System.EventHandler(this.miABateau_Click);
            // 
            // miAjouterTraversee
            // 
            this.miAjouterTraversee.Name = "miAjouterTraversee";
            this.miAjouterTraversee.Size = new System.Drawing.Size(287, 22);
            this.miAjouterTraversee.Text = "Une traversée";
            this.miAjouterTraversee.Click += new System.EventHandler(this.miAjouterTraversee_Click);
            // 
            // mmModifier
            // 
            this.mmModifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMBateau,
            this.miParametresSite});
            this.mmModifier.Name = "mmModifier";
            this.mmModifier.Size = new System.Drawing.Size(64, 20);
            this.mmModifier.Text = "Modifier";
            // 
            // miMBateau
            // 
            this.miMBateau.Name = "miMBateau";
            this.miMBateau.Size = new System.Drawing.Size(191, 22);
            this.miMBateau.Text = "Un bateau";
            this.miMBateau.Click += new System.EventHandler(this.miMBateau_Click);
            // 
            // miParametresSite
            // 
            this.miParametresSite.Name = "miParametresSite";
            this.miParametresSite.Size = new System.Drawing.Size(191, 22);
            this.miParametresSite.Text = "Les paramètres du site";
            this.miParametresSite.Click += new System.EventHandler(this.miParametresSite_Click);
            // 
            // mmAfficher
            // 
            this.mmAfficher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAfficherTraversee,
            this.miDetails});
            this.mmAfficher.Name = "mmAfficher";
            this.mmAfficher.Size = new System.Drawing.Size(61, 20);
            this.mmAfficher.Text = "Afficher";
            // 
            // miAfficherTraversee
            // 
            this.miAfficherTraversee.Name = "miAfficherTraversee";
            this.miAfficherTraversee.Size = new System.Drawing.Size(524, 22);
            this.miAfficherTraversee.Text = "Les traversées pour une liaison et une date donnée avec places restantes par caté" +
    "gorie";
            this.miAfficherTraversee.Click += new System.EventHandler(this.miAfficherTraversee_Click);
            // 
            // miDetails
            // 
            this.miDetails.Name = "miDetails";
            this.miDetails.Size = new System.Drawing.Size(524, 22);
            this.miDetails.Text = "Les détails d\'une réservation pour un client";
            this.miDetails.Click += new System.EventHandler(this.miDetails_Click);
            // 
            // mmAPropos
            // 
            this.mmAPropos.Name = "mmAPropos";
            this.mmAPropos.Size = new System.Drawing.Size(67, 20);
            this.mmAPropos.Text = "A Propos";
            // 
            // customInstaller1
            // 
            this.customInstaller1.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.customInstaller1_AfterInstall);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msPrincipal);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "FormAccueil";
            this.Text = "Atlantik - Accueil";
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mmAjouter;
        private System.Windows.Forms.ToolStripMenuItem miSecteur;
        private System.Windows.Forms.ToolStripMenuItem miPort;
        private System.Windows.Forms.ToolStripMenuItem miLiaison;
        private System.Windows.Forms.ToolStripMenuItem miTarifs;
        private System.Windows.Forms.ToolStripMenuItem miABateau;
        private System.Windows.Forms.ToolStripMenuItem miAjouterTraversee;
        private System.Windows.Forms.ToolStripMenuItem mmModifier;
        private System.Windows.Forms.ToolStripMenuItem miMBateau;
        private System.Windows.Forms.ToolStripMenuItem miParametresSite;
        private System.Windows.Forms.ToolStripMenuItem mmAfficher;
        private System.Windows.Forms.ToolStripMenuItem miAfficherTraversee;
        private System.Windows.Forms.ToolStripMenuItem miDetails;
        private System.Windows.Forms.ToolStripMenuItem mmAPropos;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
    }
}

