namespace WindowsForm
{
    partial class FormAjoutLiaison
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
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblArrivee = new System.Windows.Forms.Label();
            this.cmbPortDepart = new System.Windows.Forms.ComboBox();
            this.cmbPortArrivee = new System.Windows.Forms.ComboBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.nudDistance = new System.Windows.Forms.NumericUpDown();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.Location = new System.Drawing.Point(80, 84);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(121, 212);
            this.lbxSecteur.TabIndex = 0;
            this.lbxSecteur.Validated += new System.EventHandler(this.lbxSecteur_Validated);
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSecteur.Location = new System.Drawing.Point(76, 27);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(72, 20);
            this.lblSecteur.TabIndex = 3;
            this.lblSecteur.Text = "Secteur:";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblDepart.Location = new System.Drawing.Point(281, 84);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(70, 20);
            this.lblDepart.TabIndex = 4;
            this.lblDepart.Text = "Départ :";
            // 
            // lblArrivee
            // 
            this.lblArrivee.AutoSize = true;
            this.lblArrivee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblArrivee.Location = new System.Drawing.Point(536, 84);
            this.lblArrivee.Name = "lblArrivee";
            this.lblArrivee.Size = new System.Drawing.Size(72, 20);
            this.lblArrivee.TabIndex = 5;
            this.lblArrivee.Text = "Arrivée :";
            // 
            // cmbPortDepart
            // 
            this.cmbPortDepart.FormattingEnabled = true;
            this.cmbPortDepart.Location = new System.Drawing.Point(374, 86);
            this.cmbPortDepart.Name = "cmbPortDepart";
            this.cmbPortDepart.Size = new System.Drawing.Size(121, 21);
            this.cmbPortDepart.TabIndex = 6;
            this.cmbPortDepart.Validated += new System.EventHandler(this.cmbPortDepart_Validated);
            // 
            // cmbPortArrivee
            // 
            this.cmbPortArrivee.FormattingEnabled = true;
            this.cmbPortArrivee.Location = new System.Drawing.Point(635, 86);
            this.cmbPortArrivee.Name = "cmbPortArrivee";
            this.cmbPortArrivee.Size = new System.Drawing.Size(121, 21);
            this.cmbPortArrivee.TabIndex = 7;
            this.cmbPortArrivee.Validated += new System.EventHandler(this.cmbPortArrivee_Validated);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblDistance.Location = new System.Drawing.Point(536, 202);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(86, 20);
            this.lblDistance.TabIndex = 8;
            this.lblDistance.Text = "Distance :";
            // 
            // nudDistance
            // 
            this.nudDistance.Location = new System.Drawing.Point(636, 202);
            this.nudDistance.Name = "nudDistance";
            this.nudDistance.Size = new System.Drawing.Size(120, 20);
            this.nudDistance.TabIndex = 9;
            this.nudDistance.Validated += new System.EventHandler(this.nudDistance_Validated);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(636, 264);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(120, 32);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormAjoutLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.nudDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.cmbPortArrivee);
            this.Controls.Add(this.cmbPortDepart);
            this.Controls.Add(this.lblArrivee);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteur);
            this.Name = "FormAjoutLiaison";
            this.Text = "Ajouter liaison";
            this.Load += new System.EventHandler(this.AjoutLiaison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblArrivee;
        private System.Windows.Forms.ComboBox cmbPortDepart;
        private System.Windows.Forms.ComboBox cmbPortArrivee;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.NumericUpDown nudDistance;
        private System.Windows.Forms.Button btnAjouter;
    }
}