
namespace Hangman
{
    partial class frmRezultat
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
            this.lblTekst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTekst
            // 
            this.lblTekst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTekst.AutoSize = true;
            this.lblTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTekst.Location = new System.Drawing.Point(12, 20);
            this.lblTekst.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(0, 25);
            this.lblTekst.TabIndex = 1;
            // 
            // frmRezultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 248);
            this.Controls.Add(this.lblTekst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRezultat";
            this.Text = "Uspjeh";
            this.Load += new System.EventHandler(this.frmRezultat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTekst;
    }
}