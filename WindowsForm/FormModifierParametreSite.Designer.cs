namespace WindowsForm
{
    partial class FormModifierParametreSite
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
            this.gbx = new System.Windows.Forms.GroupBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblRang = new System.Windows.Forms.Label();
            this.lblCleHMAC = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.tbxSite = new System.Windows.Forms.TextBox();
            this.tbxRang = new System.Windows.Forms.TextBox();
            this.tbxCleHMAC = new System.Windows.Forms.TextBox();
            this.tbxIdentifiant = new System.Windows.Forms.TextBox();
            this.cbxEnProduction = new System.Windows.Forms.CheckBox();
            this.tbxMelSite = new System.Windows.Forms.TextBox();
            this.lblMelSite = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.tbxCleHMAC);
            this.gbx.Controls.Add(this.tbxIdentifiant);
            this.gbx.Controls.Add(this.tbxRang);
            this.gbx.Controls.Add(this.tbxSite);
            this.gbx.Controls.Add(this.lblCleHMAC);
            this.gbx.Controls.Add(this.lblIdentifiant);
            this.gbx.Controls.Add(this.lblRang);
            this.gbx.Controls.Add(this.lblSite);
            this.gbx.Location = new System.Drawing.Point(213, 12);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(339, 299);
            this.gbx.TabIndex = 0;
            this.gbx.TabStop = false;
            this.gbx.Text = "Identifiants PayBox";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblSite.Location = new System.Drawing.Point(25, 29);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(40, 17);
            this.lblSite.TabIndex = 0;
            this.lblSite.Text = "Site :";
            // 
            // lblRang
            // 
            this.lblRang.AutoSize = true;
            this.lblRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblRang.Location = new System.Drawing.Point(25, 66);
            this.lblRang.Name = "lblRang";
            this.lblRang.Size = new System.Drawing.Size(50, 17);
            this.lblRang.TabIndex = 1;
            this.lblRang.Text = "Rang :";
            // 
            // lblCleHMAC
            // 
            this.lblCleHMAC.AutoSize = true;
            this.lblCleHMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCleHMAC.Location = new System.Drawing.Point(25, 149);
            this.lblCleHMAC.Name = "lblCleHMAC";
            this.lblCleHMAC.Size = new System.Drawing.Size(79, 17);
            this.lblCleHMAC.TabIndex = 3;
            this.lblCleHMAC.Text = "Clé HMAC :";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblIdentifiant.Location = new System.Drawing.Point(25, 112);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(77, 17);
            this.lblIdentifiant.TabIndex = 2;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // tbxSite
            // 
            this.tbxSite.Location = new System.Drawing.Point(130, 29);
            this.tbxSite.Name = "tbxSite";
            this.tbxSite.Size = new System.Drawing.Size(120, 20);
            this.tbxSite.TabIndex = 4;
            // 
            // tbxRang
            // 
            this.tbxRang.Location = new System.Drawing.Point(130, 66);
            this.tbxRang.Name = "tbxRang";
            this.tbxRang.Size = new System.Drawing.Size(35, 20);
            this.tbxRang.TabIndex = 5;
            // 
            // tbxCleHMAC
            // 
            this.tbxCleHMAC.Location = new System.Drawing.Point(130, 149);
            this.tbxCleHMAC.Multiline = true;
            this.tbxCleHMAC.Name = "tbxCleHMAC";
            this.tbxCleHMAC.Size = new System.Drawing.Size(190, 141);
            this.tbxCleHMAC.TabIndex = 7;
            // 
            // tbxIdentifiant
            // 
            this.tbxIdentifiant.Location = new System.Drawing.Point(130, 112);
            this.tbxIdentifiant.Name = "tbxIdentifiant";
            this.tbxIdentifiant.Size = new System.Drawing.Size(120, 20);
            this.tbxIdentifiant.TabIndex = 6;
            // 
            // cbxEnProduction
            // 
            this.cbxEnProduction.AutoSize = true;
            this.cbxEnProduction.Location = new System.Drawing.Point(460, 326);
            this.cbxEnProduction.Name = "cbxEnProduction";
            this.cbxEnProduction.Size = new System.Drawing.Size(92, 17);
            this.cbxEnProduction.TabIndex = 1;
            this.cbxEnProduction.Text = "En production";
            this.cbxEnProduction.UseVisualStyleBackColor = true;
            // 
            // tbxMelSite
            // 
            this.tbxMelSite.Location = new System.Drawing.Point(361, 363);
            this.tbxMelSite.Name = "tbxMelSite";
            this.tbxMelSite.Size = new System.Drawing.Size(191, 20);
            this.tbxMelSite.TabIndex = 6;
            // 
            // lblMelSite
            // 
            this.lblMelSite.AutoSize = true;
            this.lblMelSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblMelSite.Location = new System.Drawing.Point(237, 363);
            this.lblMelSite.Name = "lblMelSite";
            this.lblMelSite.Size = new System.Drawing.Size(73, 20);
            this.lblMelSite.TabIndex = 5;
            this.lblMelSite.Text = "Mel site:";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(361, 408);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(191, 30);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // FormModifierParametreSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.tbxMelSite);
            this.Controls.Add(this.lblMelSite);
            this.Controls.Add(this.cbxEnProduction);
            this.Controls.Add(this.gbx);
            this.Name = "FormModifierParametreSite";
            this.Text = "Modifier les paramètres du site";
            this.Load += new System.EventHandler(this.FormModifierParametreSite_Load);
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.TextBox tbxCleHMAC;
        private System.Windows.Forms.TextBox tbxIdentifiant;
        private System.Windows.Forms.TextBox tbxRang;
        private System.Windows.Forms.TextBox tbxSite;
        private System.Windows.Forms.Label lblCleHMAC;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblRang;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.CheckBox cbxEnProduction;
        private System.Windows.Forms.TextBox tbxMelSite;
        private System.Windows.Forms.Label lblMelSite;
        private System.Windows.Forms.Button btnModifier;
    }
}