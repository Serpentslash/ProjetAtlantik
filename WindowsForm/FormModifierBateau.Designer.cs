namespace WindowsForm
{
    partial class FormModifierBateau
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
            this.gbxCapaciteMax = new System.Windows.Forms.GroupBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblNomBateau = new System.Windows.Forms.Label();
            this.cmbBateau = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // gbxCapaciteMax
            // 
            this.gbxCapaciteMax.Location = new System.Drawing.Point(406, 76);
            this.gbxCapaciteMax.Name = "gbxCapaciteMax";
            this.gbxCapaciteMax.Size = new System.Drawing.Size(334, 298);
            this.gbxCapaciteMax.TabIndex = 7;
            this.gbxCapaciteMax.TabStop = false;
            this.gbxCapaciteMax.Text = "Capacités Maximales";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(175, 351);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(150, 23);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNomBateau.Location = new System.Drawing.Point(60, 76);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(109, 20);
            this.lblNomBateau.TabIndex = 4;
            this.lblNomBateau.Text = "Nom bateau :";
            // 
            // cmbBateau
            // 
            this.cmbBateau.FormattingEnabled = true;
            this.cmbBateau.Location = new System.Drawing.Point(175, 76);
            this.cmbBateau.Name = "cmbBateau";
            this.cmbBateau.Size = new System.Drawing.Size(150, 21);
            this.cmbBateau.TabIndex = 8;
            this.cmbBateau.SelectedIndexChanged += new System.EventHandler(this.cmbBateau_SelectedIndexChanged);
            this.cmbBateau.Validated += new System.EventHandler(this.cmbBateau_Validated);
            // 
            // ModifierBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbBateau);
            this.Controls.Add(this.gbxCapaciteMax);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblNomBateau);
            this.Name = "ModifierBateau";
            this.Text = "Modifier un bateau";
            this.Load += new System.EventHandler(this.ModifierBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCapaciteMax;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.ComboBox cmbBateau;
    }
}