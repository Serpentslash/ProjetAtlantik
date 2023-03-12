namespace WindowsForm
{
    partial class FormAfficherTraversees
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
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTraversee = new System.Windows.Forms.DateTimePicker();
            this.lvTraversees = new System.Windows.Forms.ListView();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(33, 323);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaison.TabIndex = 12;
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblLiaison.Location = new System.Drawing.Point(29, 281);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(73, 20);
            this.lblLiaison.TabIndex = 11;
            this.lblLiaison.Text = "Liaison :";
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSecteur.Location = new System.Drawing.Point(29, 14);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(72, 20);
            this.lblSecteur.TabIndex = 10;
            this.lblSecteur.Text = "Secteur:";
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.Location = new System.Drawing.Point(33, 49);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(121, 212);
            this.lbxSecteur.TabIndex = 9;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblDate.Location = new System.Drawing.Point(258, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(243, 20);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date (par défaut celle du jour) :";
            // 
            // dateTraversee
            // 
            this.dateTraversee.CustomFormat = "dd/MM/yyyy";
            this.dateTraversee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTraversee.Location = new System.Drawing.Point(520, 21);
            this.dateTraversee.Name = "dateTraversee";
            this.dateTraversee.Size = new System.Drawing.Size(98, 20);
            this.dateTraversee.TabIndex = 14;
            this.dateTraversee.Value = new System.DateTime(2023, 3, 12, 0, 0, 0, 0);
            // 
            // lvTraversees
            // 
            this.lvTraversees.HideSelection = false;
            this.lvTraversees.Location = new System.Drawing.Point(192, 173);
            this.lvTraversees.Name = "lvTraversees";
            this.lvTraversees.Size = new System.Drawing.Size(564, 265);
            this.lvTraversees.TabIndex = 15;
            this.lvTraversees.UseCompatibleStateImageBehavior = false;
            // 
            // btnAfficher
            // 
            this.btnAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAfficher.Location = new System.Drawing.Point(349, 69);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(215, 35);
            this.btnAfficher.TabIndex = 16;
            this.btnAfficher.Text = "Afficher les traversées";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // FormAfficherTraversees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.lvTraversees);
            this.Controls.Add(this.dateTraversee);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteur);
            this.Name = "FormAfficherTraversees";
            this.Text = "Afficher les traversées pour une liaison et une date donnée avec places restantes" +
    " par catégorie";
            this.Load += new System.EventHandler(this.FormAfficherTraversees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTraversee;
        private System.Windows.Forms.ListView lvTraversees;
        private System.Windows.Forms.Button btnAfficher;
    }
}