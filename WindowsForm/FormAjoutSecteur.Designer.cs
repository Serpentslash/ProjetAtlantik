namespace WindowsForm
{
    partial class FormAjoutSecteur
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
            this.lblNomSecteur = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.tbxSecteur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomSecteur
            // 
            this.lblNomSecteur.AutoSize = true;
            this.lblNomSecteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNomSecteur.Location = new System.Drawing.Point(201, 154);
            this.lblNomSecteur.Name = "lblNomSecteur";
            this.lblNomSecteur.Size = new System.Drawing.Size(110, 20);
            this.lblNomSecteur.TabIndex = 0;
            this.lblNomSecteur.Text = "Nom secteur:";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(346, 287);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 29);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.AjoutSecteurClick);
            // 
            // tbxSecteur
            // 
            this.tbxSecteur.Location = new System.Drawing.Point(346, 156);
            this.tbxSecteur.Name = "tbxSecteur";
            this.tbxSecteur.Size = new System.Drawing.Size(100, 20);
            this.tbxSecteur.TabIndex = 2;
            this.tbxSecteur.Validated += new System.EventHandler(this.tbxSecteur_Validated);
            // 
            // AjoutSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxSecteur);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblNomSecteur);
            this.Name = "AjoutSecteur";
            this.Text = "Ajouter secteur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomSecteur;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox tbxSecteur;
    }
}