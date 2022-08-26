
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
            this.components = new System.ComponentModel.Container();
            this.lblPravilaIgre = new System.Windows.Forms.Label();
            this.btnZapocni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPravilaIgre
            // 
            this.lblPravilaIgre.AutoSize = true;
            this.lblPravilaIgre.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPravilaIgre.Location = new System.Drawing.Point(122, 57);
            this.lblPravilaIgre.Name = "lblPravilaIgre";
            this.lblPravilaIgre.Size = new System.Drawing.Size(448, 52);
            this.lblPravilaIgre.TabIndex = 0;
            this.lblPravilaIgre.Text = "DOBRODOŠLI NA IGRICU POGAĐANJA RIJEČI!!!! :)\r\n\r\n";
            // 
            // btnZapocni
            // 
            this.btnZapocni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZapocni.BackColor = System.Drawing.Color.LimeGreen;
            this.btnZapocni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZapocni.Enabled = false;
            this.btnZapocni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnZapocni.Location = new System.Drawing.Point(255, 483);
            this.btnZapocni.Name = "btnZapocni";
            this.btnZapocni.Size = new System.Drawing.Size(219, 50);
            this.btnZapocni.TabIndex = 2;
            this.btnZapocni.Text = "Započni igricu";
            this.btnZapocni.UseVisualStyleBackColor = false;
            this.btnZapocni.Click += new System.EventHandler(this.btnZapocni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unesite svoje ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Uživajte i sretno!!! :)";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(287, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 34);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 545);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZapocni);
            this.Controls.Add(this.lblPravilaIgre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHangman";
            this.Text = "Započnite igru";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPravilaIgre;
        private System.Windows.Forms.Button btnZapocni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider err;
    }
}

