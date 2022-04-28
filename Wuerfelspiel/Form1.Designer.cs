namespace Wuerfelspiel
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWuerfeln = new System.Windows.Forms.Button();
            this.lblWuerfel = new System.Windows.Forms.Label();
            this.ucWuerfel1 = new Wuerfelspiel.UCWuerfel();
            this.SuspendLayout();
            // 
            // btnWuerfeln
            // 
            this.btnWuerfeln.Location = new System.Drawing.Point(371, 197);
            this.btnWuerfeln.Name = "btnWuerfeln";
            this.btnWuerfeln.Size = new System.Drawing.Size(75, 23);
            this.btnWuerfeln.TabIndex = 0;
            this.btnWuerfeln.Text = "Würfeln";
            this.btnWuerfeln.UseVisualStyleBackColor = true;
            this.btnWuerfeln.Click += new System.EventHandler(this.BtnWuerfeln_Click);
            // 
            // lblWuerfel
            // 
            this.lblWuerfel.AutoSize = true;
            this.lblWuerfel.Location = new System.Drawing.Point(331, 139);
            this.lblWuerfel.Name = "lblWuerfel";
            this.lblWuerfel.Size = new System.Drawing.Size(35, 13);
            this.lblWuerfel.TabIndex = 1;
            this.lblWuerfel.Text = "label1";
            // 
            // ucWuerfel1
            // 
            this.ucWuerfel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucWuerfel1.Location = new System.Drawing.Point(109, 81);
            this.ucWuerfel1.Name = "ucWuerfel1";
            this.ucWuerfel1.Size = new System.Drawing.Size(155, 139);
            this.ucWuerfel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucWuerfel1);
            this.Controls.Add(this.lblWuerfel);
            this.Controls.Add(this.btnWuerfeln);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWuerfeln;
        private System.Windows.Forms.Label lblWuerfel;
        private UCWuerfel ucWuerfel1;
    }
}

