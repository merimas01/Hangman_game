
namespace Hangman
{
    partial class frmIgraj
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
            this.lblPogodiRijec = new System.Windows.Forms.Label();
            this.lblNepoznataRijec = new System.Windows.Forms.Label();
            this.lblPokusaj = new System.Windows.Forms.Label();
            this.lblBrojacPokusaja = new System.Windows.Forms.Label();
            this.txtUnos = new System.Windows.Forms.TextBox();
            this.lblUkucaj = new System.Windows.Forms.Label();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnNovaIgra = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPogodiRijec
            // 
            this.lblPogodiRijec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPogodiRijec.AutoSize = true;
            this.lblPogodiRijec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPogodiRijec.Location = new System.Drawing.Point(37, 60);
            this.lblPogodiRijec.Name = "lblPogodiRijec";
            this.lblPogodiRijec.Size = new System.Drawing.Size(119, 25);
            this.lblPogodiRijec.TabIndex = 0;
            this.lblPogodiRijec.Text = "Pogodi riječ:";
            // 
            // lblNepoznataRijec
            // 
            this.lblNepoznataRijec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNepoznataRijec.AutoSize = true;
            this.lblNepoznataRijec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNepoznataRijec.Location = new System.Drawing.Point(267, 45);
            this.lblNepoznataRijec.Name = "lblNepoznataRijec";
            this.lblNepoznataRijec.Size = new System.Drawing.Size(0, 39);
            this.lblNepoznataRijec.TabIndex = 1;
            // 
            // lblPokusaj
            // 
            this.lblPokusaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPokusaj.AutoSize = true;
            this.lblPokusaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPokusaj.Location = new System.Drawing.Point(37, 238);
            this.lblPokusaj.Name = "lblPokusaj";
            this.lblPokusaj.Size = new System.Drawing.Size(141, 25);
            this.lblPokusaj.TabIndex = 2;
            this.lblPokusaj.Text = "Broj pokušaja: ";
            // 
            // lblBrojacPokusaja
            // 
            this.lblBrojacPokusaja.AutoSize = true;
            this.lblBrojacPokusaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBrojacPokusaja.Location = new System.Drawing.Point(224, 238);
            this.lblBrojacPokusaja.Name = "lblBrojacPokusaja";
            this.lblBrojacPokusaja.Size = new System.Drawing.Size(0, 25);
            this.lblBrojacPokusaja.TabIndex = 3;
            // 
            // txtUnos
            // 
            this.txtUnos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUnos.Location = new System.Drawing.Point(229, 144);
            this.txtUnos.Name = "txtUnos";
            this.txtUnos.Size = new System.Drawing.Size(348, 30);
            this.txtUnos.TabIndex = 5;
            // 
            // lblUkucaj
            // 
            this.lblUkucaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUkucaj.AutoSize = true;
            this.lblUkucaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUkucaj.Location = new System.Drawing.Point(37, 147);
            this.lblUkucaj.Name = "lblUkucaj";
            this.lblUkucaj.Size = new System.Drawing.Size(170, 25);
            this.lblUkucaj.TabIndex = 6;
            this.lblUkucaj.Text = "Ukucaj slovo/riječ:";
            // 
            // lblPoruka
            // 
            this.lblPoruka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.BackColor = System.Drawing.Color.White;
            this.lblPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPoruka.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblPoruka.Location = new System.Drawing.Point(37, 300);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 29);
            this.lblPoruka.TabIndex = 7;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPotvrdi.BackColor = System.Drawing.Color.MintCream;
            this.btnPotvrdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPotvrdi.Location = new System.Drawing.Point(595, 141);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(117, 41);
            this.btnPotvrdi.TabIndex = 8;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnNovaIgra
            // 
            this.btnNovaIgra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaIgra.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNovaIgra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaIgra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaIgra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovaIgra.Location = new System.Drawing.Point(595, 216);
            this.btnNovaIgra.Name = "btnNovaIgra";
            this.btnNovaIgra.Size = new System.Drawing.Size(117, 47);
            this.btnNovaIgra.TabIndex = 9;
            this.btnNovaIgra.Text = "Nova igra";
            this.btnNovaIgra.UseVisualStyleBackColor = false;
            this.btnNovaIgra.Click += new System.EventHandler(this.btnNovaIgra_Click);
            // 
            // btnScore
            // 
            this.btnScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnScore.Location = new System.Drawing.Point(595, 284);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(117, 45);
            this.btnScore.TabIndex = 11;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = false;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // Igraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 384);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnNovaIgra);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.lblUkucaj);
            this.Controls.Add(this.txtUnos);
            this.Controls.Add(this.lblBrojacPokusaja);
            this.Controls.Add(this.lblPokusaj);
            this.Controls.Add(this.lblNepoznataRijec);
            this.Controls.Add(this.lblPogodiRijec);
            this.MaximizeBox = false;
            this.Name = "Igraj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Igraj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPogodiRijec;
        private System.Windows.Forms.Label lblNepoznataRijec;
        private System.Windows.Forms.Label lblPokusaj;
        private System.Windows.Forms.Label lblBrojacPokusaja;
        private System.Windows.Forms.TextBox txtUnos;
        private System.Windows.Forms.Label lblUkucaj;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnNovaIgra;
        private System.Windows.Forms.Button btnScore;
    }
}