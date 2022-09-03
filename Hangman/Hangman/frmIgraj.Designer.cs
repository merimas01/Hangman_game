
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
            this.components = new System.ComponentModel.Container();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.lblBrojacHint = new System.Windows.Forms.Label();
            this.btnChallenging = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSentences = new System.Windows.Forms.Button();
            this.lblTimerText = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.lblBodovi = new System.Windows.Forms.Label();
            this.lblBodoviText = new System.Windows.Forms.Label();
            this.lblBrojSlova = new System.Windows.Forms.Label();
            this.lblBrojSlovaText = new System.Windows.Forms.Label();
            this.btnMode = new System.Windows.Forms.Button();
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.lblBrojRijeci = new System.Windows.Forms.Label();
            this.lblObjasnjenje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPogodiRijec
            // 
            this.lblPogodiRijec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPogodiRijec.AutoSize = true;
            this.lblPogodiRijec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPogodiRijec.Location = new System.Drawing.Point(110, 223);
            this.lblPogodiRijec.Name = "lblPogodiRijec";
            this.lblPogodiRijec.Size = new System.Drawing.Size(147, 25);
            this.lblPogodiRijec.TabIndex = 0;
            this.lblPogodiRijec.Text = "Probaj pogoditi:";
            // 
            // lblNepoznataRijec
            // 
            this.lblNepoznataRijec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNepoznataRijec.AutoSize = true;
            this.lblNepoznataRijec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNepoznataRijec.Location = new System.Drawing.Point(388, 209);
            this.lblNepoznataRijec.Name = "lblNepoznataRijec";
            this.lblNepoznataRijec.Size = new System.Drawing.Size(0, 39);
            this.lblNepoznataRijec.TabIndex = 1;
            // 
            // lblPokusaj
            // 
            this.lblPokusaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPokusaj.AutoSize = true;
            this.lblPokusaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPokusaj.Location = new System.Drawing.Point(110, 401);
            this.lblPokusaj.Name = "lblPokusaj";
            this.lblPokusaj.Size = new System.Drawing.Size(132, 25);
            this.lblPokusaj.TabIndex = 2;
            this.lblPokusaj.Text = "Broj grešaka: ";
            // 
            // lblBrojacPokusaja
            // 
            this.lblBrojacPokusaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBrojacPokusaja.AutoSize = true;
            this.lblBrojacPokusaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBrojacPokusaja.Location = new System.Drawing.Point(394, 401);
            this.lblBrojacPokusaja.Name = "lblBrojacPokusaja";
            this.lblBrojacPokusaja.Size = new System.Drawing.Size(0, 25);
            this.lblBrojacPokusaja.TabIndex = 3;
            // 
            // txtUnos
            // 
            this.txtUnos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnos.BackColor = System.Drawing.Color.SeaShell;
            this.txtUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUnos.Location = new System.Drawing.Point(395, 307);
            this.txtUnos.Name = "txtUnos";
            this.txtUnos.Size = new System.Drawing.Size(315, 30);
            this.txtUnos.TabIndex = 5;
            // 
            // lblUkucaj
            // 
            this.lblUkucaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUkucaj.AutoSize = true;
            this.lblUkucaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUkucaj.Location = new System.Drawing.Point(110, 310);
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
            this.lblPoruka.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPoruka.Location = new System.Drawing.Point(111, 636);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 29);
            this.lblPoruka.TabIndex = 7;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPotvrdi.BackColor = System.Drawing.Color.MintCream;
            this.btnPotvrdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnPotvrdi.Location = new System.Drawing.Point(738, 304);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(61, 40);
            this.btnPotvrdi.TabIndex = 8;
            this.btnPotvrdi.Text = "OK";
            this.toolTip4.SetToolTip(this.btnPotvrdi, "potvrdite unos");
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnNovaIgra
            // 
            this.btnNovaIgra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaIgra.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNovaIgra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaIgra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaIgra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovaIgra.Location = new System.Drawing.Point(926, 624);
            this.btnNovaIgra.Name = "btnNovaIgra";
            this.btnNovaIgra.Size = new System.Drawing.Size(132, 47);
            this.btnNovaIgra.TabIndex = 9;
            this.btnNovaIgra.Text = "Nova riječ";
            this.toolTip5.SetToolTip(this.btnNovaIgra, "prebacite na slijedeću riječ");
            this.btnNovaIgra.UseVisualStyleBackColor = false;
            this.btnNovaIgra.Click += new System.EventHandler(this.btnNovaIgra_Click);
            // 
            // btnScore
            // 
            this.btnScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScore.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnScore.Location = new System.Drawing.Point(1069, 624);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(117, 47);
            this.btnScore.TabIndex = 11;
            this.btnScore.Text = "Uspjeh";
            this.toolTip1.SetToolTip(this.btnScore, "Vaš ukupni uspjeh");
            this.btnScore.UseVisualStyleBackColor = false;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.BackColor = System.Drawing.Color.MintCream;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHelp.FlatAppearance.BorderSize = 50;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHelp.Location = new System.Drawing.Point(115, 496);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(73, 44);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "Pomoć";
            this.toolTip3.SetToolTip(this.btnHelp, "kliknite da dobijete pomoćno slovo");
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Location = new System.Drawing.Point(112, 552);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(256, 24);
            this.lblHelp.TabIndex = 13;
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(1107, 16);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 34);
            this.btnInfo.TabIndex = 14;
            this.btnInfo.Text = "INFO";
            this.toolTip2.SetToolTip(this.btnInfo, "pravila igre");
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblBrojacHint
            // 
            this.lblBrojacHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBrojacHint.AutoSize = true;
            this.lblBrojacHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojacHint.ForeColor = System.Drawing.Color.Black;
            this.lblBrojacHint.Location = new System.Drawing.Point(206, 507);
            this.lblBrojacHint.Name = "lblBrojacHint";
            this.lblBrojacHint.Size = new System.Drawing.Size(0, 20);
            this.lblBrojacHint.TabIndex = 15;
            // 
            // btnChallenging
            // 
            this.btnChallenging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChallenging.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChallenging.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChallenging.Enabled = false;
            this.btnChallenging.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnChallenging.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChallenging.Location = new System.Drawing.Point(1000, 401);
            this.btnChallenging.Name = "btnChallenging";
            this.btnChallenging.Size = new System.Drawing.Size(182, 110);
            this.btnChallenging.TabIndex = 23;
            this.btnChallenging.Text = "IZAZOVI SE";
            this.btnChallenging.UseVisualStyleBackColor = false;
            this.btnChallenging.Click += new System.EventHandler(this.btnChallenging_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSentences
            // 
            this.btnSentences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSentences.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSentences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSentences.Enabled = false;
            this.btnSentences.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSentences.Location = new System.Drawing.Point(1000, 267);
            this.btnSentences.Name = "btnSentences";
            this.btnSentences.Size = new System.Drawing.Size(182, 110);
            this.btnSentences.TabIndex = 25;
            this.btnSentences.Text = "LATINSKE IZREKE";
            this.btnSentences.UseVisualStyleBackColor = false;
            this.btnSentences.Click += new System.EventHandler(this.btnSentences_Click);
            // 
            // lblTimerText
            // 
            this.lblTimerText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerText.AutoSize = true;
            this.lblTimerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerText.Location = new System.Drawing.Point(398, 23);
            this.lblTimerText.Name = "lblTimerText";
            this.lblTimerText.Size = new System.Drawing.Size(63, 20);
            this.lblTimerText.TabIndex = 26;
            this.lblTimerText.Text = "Timer:";
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(468, 23);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(45, 20);
            this.lblTimer.TabIndex = 27;
            this.lblTimer.Text = "OFF";
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnNazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNazad.Enabled = false;
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNazad.Location = new System.Drawing.Point(42, 16);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(114, 35);
            this.btnNazad.TabIndex = 28;
            this.btnNazad.Text = "Nazad";
            this.toolTip6.SetToolTip(this.btnNazad, "nazad na početnu igru");
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // lblBodovi
            // 
            this.lblBodovi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBodovi.AutoSize = true;
            this.lblBodovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodovi.Location = new System.Drawing.Point(691, 23);
            this.lblBodovi.Name = "lblBodovi";
            this.lblBodovi.Size = new System.Drawing.Size(19, 20);
            this.lblBodovi.TabIndex = 32;
            this.lblBodovi.Text = "0";
            // 
            // lblBodoviText
            // 
            this.lblBodoviText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBodoviText.AutoSize = true;
            this.lblBodoviText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodoviText.Location = new System.Drawing.Point(607, 23);
            this.lblBodoviText.Name = "lblBodoviText";
            this.lblBodoviText.Size = new System.Drawing.Size(65, 20);
            this.lblBodoviText.TabIndex = 31;
            this.lblBodoviText.Text = "Bodovi:";
            // 
            // lblBrojSlova
            // 
            this.lblBrojSlova.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrojSlova.AutoSize = true;
            this.lblBrojSlova.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojSlova.Location = new System.Drawing.Point(913, 23);
            this.lblBrojSlova.Name = "lblBrojSlova";
            this.lblBrojSlova.Size = new System.Drawing.Size(16, 20);
            this.lblBrojSlova.TabIndex = 30;
            this.lblBrojSlova.Text = "-";
            // 
            // lblBrojSlovaText
            // 
            this.lblBrojSlovaText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrojSlovaText.AutoSize = true;
            this.lblBrojSlovaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojSlovaText.Location = new System.Drawing.Point(814, 23);
            this.lblBrojSlovaText.Name = "lblBrojSlovaText";
            this.lblBrojSlovaText.Size = new System.Drawing.Size(89, 20);
            this.lblBrojSlovaText.TabIndex = 29;
            this.lblBrojSlovaText.Text = "Broj slova:";
            // 
            // btnMode
            // 
            this.btnMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMode.Location = new System.Drawing.Point(1107, 66);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(75, 35);
            this.btnMode.TabIndex = 33;
            this.btnMode.Text = "LIGHT";
            this.toolTip7.SetToolTip(this.btnMode, "light/dark mode");
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // lblBrojRijeci
            // 
            this.lblBrojRijeci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrojRijeci.AutoSize = true;
            this.lblBrojRijeci.BackColor = System.Drawing.Color.Gray;
            this.lblBrojRijeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojRijeci.ForeColor = System.Drawing.Color.White;
            this.lblBrojRijeci.Location = new System.Drawing.Point(274, 19);
            this.lblBrojRijeci.Name = "lblBrojRijeci";
            this.lblBrojRijeci.Size = new System.Drawing.Size(19, 25);
            this.lblBrojRijeci.TabIndex = 34;
            this.lblBrojRijeci.Text = "-";
            // 
            // lblObjasnjenje
            // 
            this.lblObjasnjenje.AutoSize = true;
            this.lblObjasnjenje.Location = new System.Drawing.Point(57, 84);
            this.lblObjasnjenje.Name = "lblObjasnjenje";
            this.lblObjasnjenje.Size = new System.Drawing.Size(0, 17);
            this.lblObjasnjenje.TabIndex = 35;
            // 
            // frmIgraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1220, 705);
            this.Controls.Add(this.lblObjasnjenje);
            this.Controls.Add(this.lblBrojRijeci);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.lblBodovi);
            this.Controls.Add(this.lblBodoviText);
            this.Controls.Add(this.lblBrojSlova);
            this.Controls.Add(this.lblBrojSlovaText);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblTimerText);
            this.Controls.Add(this.btnSentences);
            this.Controls.Add(this.btnChallenging);
            this.Controls.Add(this.lblBrojacHint);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnHelp);
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
            this.Name = "frmIgraj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Igraj";
            this.Load += new System.EventHandler(this.frmIgraj_Load);
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label lblBrojacHint;
        private System.Windows.Forms.Button btnChallenging;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSentences;
        private System.Windows.Forms.Label lblTimerText;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.Label lblBodovi;
        private System.Windows.Forms.Label lblBodoviText;
        private System.Windows.Forms.Label lblBrojSlova;
        private System.Windows.Forms.Label lblBrojSlovaText;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.Label lblBrojRijeci;
        private System.Windows.Forms.Label lblObjasnjenje;
    }
}