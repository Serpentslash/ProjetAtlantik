namespace WindowsForm
{
    partial class FormAjoutBateau
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
            this.lblNomBateau = new System.Windows.Forms.Label();
            this.tbxNomBateau = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.gbxCapaciteMax = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNomBateau.Location = new System.Drawing.Point(34, 48);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(109, 20);
            this.lblNomBateau.TabIndex = 0;
            this.lblNomBateau.Text = "Nom bateau :";
            // 
            // tbxNomBateau
            // 
            this.tbxNomBateau.Location = new System.Drawing.Point(149, 48);
            this.tbxNomBateau.Name = "tbxNomBateau";
            this.tbxNomBateau.Size = new System.Drawing.Size(150, 20);
            this.tbxNomBateau.TabIndex = 1;
            this.tbxNomBateau.Validated += new System.EventHandler(this.tbxNomBateau_Validated);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(149, 323);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(150, 23);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // gbxCapaciteMax
            // 
            this.gbxCapaciteMax.Location = new System.Drawing.Point(380, 48);
            this.gbxCapaciteMax.Name = "gbxCapaciteMax";
            this.gbxCapaciteMax.Size = new System.Drawing.Size(334, 298);
            this.gbxCapaciteMax.TabIndex = 3;
            this.gbxCapaciteMax.TabStop = false;
            this.gbxCapaciteMax.Text = "Capacités Maximales";
            // 
            // AjoutBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxCapaciteMax);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.tbxNomBateau);
            this.Controls.Add(this.lblNomBateau);
            this.Name = "AjoutBateau";
            this.Text = "Ajouter un bateau";
            this.Load += new System.EventHandler(this.AjoutBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.TextBox tbxNomBateau;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox gbxCapaciteMax;
    }
}