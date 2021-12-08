
namespace Hangman
{
    partial class frmHangman
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
            this.lblPravilaIgre = new System.Windows.Forms.Label();
            this.btnAgree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPravilaIgre
            // 
            this.lblPravilaIgre.AutoSize = true;
            this.lblPravilaIgre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPravilaIgre.Location = new System.Drawing.Point(44, 41);
            this.lblPravilaIgre.Name = "lblPravilaIgre";
            this.lblPravilaIgre.Size = new System.Drawing.Size(346, 150);
            this.lblPravilaIgre.TabIndex = 0;
            this.lblPravilaIgre.Text = "Pravila igre:\r\n\r\n>> Imate 5 pokušaja da pogodite riječ. \r\n>> Možete ukucati riječ" +
    " ili slovo. \r\n\r\nSretno!";
            // 
            // btnAgree
            // 
            this.btnAgree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgree.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgree.Location = new System.Drawing.Point(153, 267);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(120, 50);
            this.btnAgree.TabIndex = 2;
            this.btnAgree.Text = "Shvatam";
            this.btnAgree.UseVisualStyleBackColor = false;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 329);
            this.Controls.Add(this.btnAgree);
            this.Controls.Add(this.lblPravilaIgre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHangman";
            this.Text = "Započnite igru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPravilaIgre;
        private System.Windows.Forms.Button btnAgree;
    }
}

