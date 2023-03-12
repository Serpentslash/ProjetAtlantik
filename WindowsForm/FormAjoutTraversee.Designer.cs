namespace WindowsForm
{
    partial class FormAjoutTraversee
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
            this.btnAjout = new System.Windows.Forms.Button();
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.cmbBateau = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDepart = new System.Windows.Forms.DateTimePicker();
            this.dateArrivee = new System.Windows.Forms.DateTimePicker();
            this.lblDateHeureDepart = new System.Windows.Forms.Label();
            this.lblDateHeureArrivee = new System.Windows.Forms.Label();
            this.lblErreurArrivee = new System.Windows.Forms.Label();
            this.lblErreurDepart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(478, 388);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(191, 29);
            this.btnAjout.TabIndex = 20;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(90, 353);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaison.TabIndex = 16;
            this.cmbLiaison.Validated += new System.EventHandler(this.cmbLiaison_Validated);
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblLiaison.Location = new System.Drawing.Point(86, 311);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(73, 20);
            this.lblLiaison.TabIndex = 15;
            this.lblLiaison.Text = "Liaison :";
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSecteur.Location = new System.Drawing.Point(86, 44);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(72, 20);
            this.lblSecteur.TabIndex = 14;
            this.lblSecteur.Text = "Secteur:";
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.Location = new System.Drawing.Point(90, 79);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(121, 212);
            this.lbxSecteur.TabIndex = 13;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            this.lbxSecteur.Validated += new System.EventHandler(this.lbxSecteur_Validated);
            // 
            // cmbBateau
            // 
            this.cmbBateau.FormattingEnabled = true;
            this.cmbBateau.Location = new System.Drawing.Point(463, 46);
            this.cmbBateau.Name = "cmbBateau";
            this.cmbBateau.Size = new System.Drawing.Size(121, 21);
            this.cmbBateau.TabIndex = 22;
            this.cmbBateau.Validated += new System.EventHandler(this.cmbBateau_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(297, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nom bateau :";
            // 
            // dateDepart
            // 
            this.dateDepart.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDepart.Location = new System.Drawing.Point(463, 190);
            this.dateDepart.Name = "dateDepart";
            this.dateDepart.Size = new System.Drawing.Size(200, 20);
            this.dateDepart.TabIndex = 23;
            this.dateDepart.Value = new System.DateTime(2023, 3, 11, 21, 6, 0, 0);
            this.dateDepart.Validated += new System.EventHandler(this.dateDepart_Validated);
            // 
            // dateArrivee
            // 
            this.dateArrivee.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateArrivee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateArrivee.Location = new System.Drawing.Point(463, 246);
            this.dateArrivee.Name = "dateArrivee";
            this.dateArrivee.Size = new System.Drawing.Size(200, 20);
            this.dateArrivee.TabIndex = 24;
            this.dateArrivee.Value = new System.DateTime(2023, 3, 11, 23, 25, 0, 0);
            this.dateArrivee.Validated += new System.EventHandler(this.dateArrivee_Validated);
            // 
            // lblDateHeureDepart
            // 
            this.lblDateHeureDepart.AutoSize = true;
            this.lblDateHeureDepart.Location = new System.Drawing.Point(324, 190);
            this.lblDateHeureDepart.Name = "lblDateHeureDepart";
            this.lblDateHeureDepart.Size = new System.Drawing.Size(126, 13);
            this.lblDateHeureDepart.TabIndex = 25;
            this.lblDateHeureDepart.Text = "Date et heure de départ :";
            // 
            // lblDateHeureArrivee
            // 
            this.lblDateHeureArrivee.AutoSize = true;
            this.lblDateHeureArrivee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDateHeureArrivee.Location = new System.Drawing.Point(324, 246);
            this.lblDateHeureArrivee.Name = "lblDateHeureArrivee";
            this.lblDateHeureArrivee.Size = new System.Drawing.Size(113, 13);
            this.lblDateHeureArrivee.TabIndex = 26;
            this.lblDateHeureArrivee.Text = "Date et heure arrivée :";
            // 
            // lblErreurArrivee
            // 
            this.lblErreurArrivee.AutoSize = true;
            this.lblErreurArrivee.BackColor = System.Drawing.SystemColors.Control;
            this.lblErreurArrivee.ForeColor = System.Drawing.Color.Red;
            this.lblErreurArrivee.Location = new System.Drawing.Point(460, 269);
            this.lblErreurArrivee.Name = "lblErreurArrivee";
            this.lblErreurArrivee.Size = new System.Drawing.Size(218, 13);
            this.lblErreurArrivee.TabIndex = 27;
            this.lblErreurArrivee.Text = "La date Arrivée se situe avant la date Départ";
            this.lblErreurArrivee.Visible = false;
            // 
            // lblErreurDepart
            // 
            this.lblErreurDepart.AutoSize = true;
            this.lblErreurDepart.BackColor = System.Drawing.SystemColors.Control;
            this.lblErreurDepart.ForeColor = System.Drawing.Color.Red;
            this.lblErreurDepart.Location = new System.Drawing.Point(460, 213);
            this.lblErreurDepart.Name = "lblErreurDepart";
            this.lblErreurDepart.Size = new System.Drawing.Size(247, 13);
            this.lblErreurDepart.TabIndex = 28;
            this.lblErreurDepart.Text = "La date Départ se situe avant la date d\'aujourd\' hui";
            this.lblErreurDepart.Visible = false;
            // 
            // FormAjoutTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErreurDepart);
            this.Controls.Add(this.lblErreurArrivee);
            this.Controls.Add(this.lblDateHeureArrivee);
            this.Controls.Add(this.lblDateHeureDepart);
            this.Controls.Add(this.dateArrivee);
            this.Controls.Add(this.dateDepart);
            this.Controls.Add(this.cmbBateau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteur);
            this.Name = "FormAjoutTraversee";
            this.Text = "Ajouter une traversée";
            this.Load += new System.EventHandler(this.AjoutTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.ComboBox cmbBateau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDepart;
        private System.Windows.Forms.DateTimePicker dateArrivee;
        private System.Windows.Forms.Label lblDateHeureDepart;
        private System.Windows.Forms.Label lblDateHeureArrivee;
        private System.Windows.Forms.Label lblErreurArrivee;
        private System.Windows.Forms.Label lblErreurDepart;
    }
}