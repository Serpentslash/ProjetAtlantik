namespace WindowsForm
{
    partial class FormAjoutTarifs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.cmbPeriode = new System.Windows.Forms.ComboBox();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.gbxTarifs = new System.Windows.Forms.GroupBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSecteur.Location = new System.Drawing.Point(41, 9);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(72, 20);
            this.lblSecteur.TabIndex = 5;
            this.lblSecteur.Text = "Secteur:";
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.Location = new System.Drawing.Point(45, 44);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(121, 212);
            this.lbxSecteur.TabIndex = 4;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            this.lbxSecteur.Validated += new System.EventHandler(this.lbxSecteur_Validated);
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(45, 318);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaison.TabIndex = 8;
            this.cmbLiaison.Validated += new System.EventHandler(this.cmbLiaison_Validated);
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblLiaison.Location = new System.Drawing.Point(41, 276);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(73, 20);
            this.lblLiaison.TabIndex = 7;
            this.lblLiaison.Text = "Liaison :";
            // 
            // cmbPeriode
            // 
            this.cmbPeriode.FormattingEnabled = true;
            this.cmbPeriode.Location = new System.Drawing.Point(45, 411);
            this.cmbPeriode.Name = "cmbPeriode";
            this.cmbPeriode.Size = new System.Drawing.Size(271, 21);
            this.cmbPeriode.TabIndex = 10;
            this.cmbPeriode.Validated += new System.EventHandler(this.cmbPeriode_Validated);
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPeriode.Location = new System.Drawing.Point(41, 369);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(76, 20);
            this.lblPeriode.TabIndex = 9;
            this.lblPeriode.Text = "Période :";
            // 
            // gbxTarifs
            // 
            this.gbxTarifs.Location = new System.Drawing.Point(389, 44);
            this.gbxTarifs.Name = "gbxTarifs";
            this.gbxTarifs.Size = new System.Drawing.Size(285, 325);
            this.gbxTarifs.TabIndex = 11;
            this.gbxTarifs.TabStop = false;
            this.gbxTarifs.Text = "Tarifs par catégorie-Type";
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(433, 406);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(191, 29);
            this.btnAjout.TabIndex = 12;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // FormAjoutTarifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.gbxTarifs);
            this.Controls.Add(this.cmbPeriode);
            this.Controls.Add(this.lblPeriode);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteur);
            this.Name = "FormAjoutTarifs";
            this.Text = "Ajouter les tarifs pour une liaison et une période";
            this.Load += new System.EventHandler(this.AjoutTarifs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.ComboBox cmbPeriode;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.GroupBox gbxTarifs;
        private System.Windows.Forms.Button btnAjout;
    }
}