namespace Opdracht4
{
    partial class formTeDoen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.tbInformatie = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblInformatie = new System.Windows.Forms.Label();
            this.btnTaakVolgende = new System.Windows.Forms.Button();
            this.btnTaakToevoegen = new System.Windows.Forms.Button();
            this.btnTaakAfgewerkt = new System.Windows.Forms.Button();
            this.btnAchteraan = new System.Windows.Forms.Button();
            this.tbTekstVeld = new System.Windows.Forms.TextBox();
            this.dtpckTijd = new System.Windows.Forms.DateTimePicker();
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.btnTekstveld = new System.Windows.Forms.Button();
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.lblTekstveld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(184, 52);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(171, 27);
            this.tbTitel.TabIndex = 0;
            // 
            // tbInformatie
            // 
            this.tbInformatie.Location = new System.Drawing.Point(184, 85);
            this.tbInformatie.Name = "tbInformatie";
            this.tbInformatie.Size = new System.Drawing.Size(171, 27);
            this.tbInformatie.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(81, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Tijdveld";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(81, 55);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(38, 20);
            this.lblTitel.TabIndex = 4;
            this.lblTitel.Text = "Titel";
            // 
            // lblInformatie
            // 
            this.lblInformatie.AutoSize = true;
            this.lblInformatie.Location = new System.Drawing.Point(81, 88);
            this.lblInformatie.Name = "lblInformatie";
            this.lblInformatie.Size = new System.Drawing.Size(78, 20);
            this.lblInformatie.TabIndex = 5;
            this.lblInformatie.Text = "Informatie";
            // 
            // btnTaakVolgende
            // 
            this.btnTaakVolgende.Location = new System.Drawing.Point(789, 55);
            this.btnTaakVolgende.Name = "btnTaakVolgende";
            this.btnTaakVolgende.Size = new System.Drawing.Size(225, 37);
            this.btnTaakVolgende.TabIndex = 6;
            this.btnTaakVolgende.Text = "Volgende taak";
            this.btnTaakVolgende.UseVisualStyleBackColor = true;
            this.btnTaakVolgende.Click += new System.EventHandler(this.btnTaakVolgende_Click);
            // 
            // btnTaakToevoegen
            // 
            this.btnTaakToevoegen.Location = new System.Drawing.Point(789, 168);
            this.btnTaakToevoegen.Name = "btnTaakToevoegen";
            this.btnTaakToevoegen.Size = new System.Drawing.Size(225, 37);
            this.btnTaakToevoegen.TabIndex = 7;
            this.btnTaakToevoegen.Text = "Taak toevoegen";
            this.btnTaakToevoegen.UseVisualStyleBackColor = true;
            this.btnTaakToevoegen.Click += new System.EventHandler(this.btnTaakToevoegen_Click);
            // 
            // btnTaakAfgewerkt
            // 
            this.btnTaakAfgewerkt.Location = new System.Drawing.Point(789, 279);
            this.btnTaakAfgewerkt.Name = "btnTaakAfgewerkt";
            this.btnTaakAfgewerkt.Size = new System.Drawing.Size(225, 37);
            this.btnTaakAfgewerkt.TabIndex = 8;
            this.btnTaakAfgewerkt.Text = "Taak is afgewerkt";
            this.btnTaakAfgewerkt.UseVisualStyleBackColor = true;
            this.btnTaakAfgewerkt.Click += new System.EventHandler(this.btnTaakAfgewerkt_Click);
            // 
            // btnAchteraan
            // 
            this.btnAchteraan.Location = new System.Drawing.Point(789, 391);
            this.btnAchteraan.Name = "btnAchteraan";
            this.btnAchteraan.Size = new System.Drawing.Size(225, 37);
            this.btnAchteraan.TabIndex = 9;
            this.btnAchteraan.Text = "Zet achteraan";
            this.btnAchteraan.UseVisualStyleBackColor = true;
            this.btnAchteraan.Click += new System.EventHandler(this.btnAchteraan_Click);
            // 
            // tbTekstVeld
            // 
            this.tbTekstVeld.Location = new System.Drawing.Point(45, 223);
            this.tbTekstVeld.Multiline = true;
            this.tbTekstVeld.Name = "tbTekstVeld";
            this.tbTekstVeld.ReadOnly = true;
            this.tbTekstVeld.Size = new System.Drawing.Size(657, 205);
            this.tbTekstVeld.TabIndex = 10;
            // 
            // dtpckTijd
            // 
            this.dtpckTijd.Location = new System.Drawing.Point(184, 17);
            this.dtpckTijd.Name = "dtpckTijd";
            this.dtpckTijd.Size = new System.Drawing.Size(250, 27);
            this.dtpckTijd.TabIndex = 11;
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Location = new System.Drawing.Point(179, 482);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(146, 37);
            this.btnMessageBox.TabIndex = 12;
            this.btnMessageBox.Text = "Uit";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // btnTekstveld
            // 
            this.btnTekstveld.Location = new System.Drawing.Point(483, 482);
            this.btnTekstveld.Name = "btnTekstveld";
            this.btnTekstveld.Size = new System.Drawing.Size(146, 37);
            this.btnTekstveld.TabIndex = 13;
            this.btnTekstveld.Text = "Uit";
            this.btnTekstveld.UseVisualStyleBackColor = true;
            this.btnTekstveld.Click += new System.EventHandler(this.btnTekstveld_Click);
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.AutoSize = true;
            this.lblMessageBox.Location = new System.Drawing.Point(81, 490);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(96, 20);
            this.lblMessageBox.TabIndex = 14;
            this.lblMessageBox.Text = "Message box";
            // 
            // lblTekstveld
            // 
            this.lblTekstveld.AutoSize = true;
            this.lblTekstveld.Location = new System.Drawing.Point(407, 490);
            this.lblTekstveld.Name = "lblTekstveld";
            this.lblTekstveld.Size = new System.Drawing.Size(70, 20);
            this.lblTekstveld.TabIndex = 15;
            this.lblTekstveld.Text = "Tekstveld";
            // 
            // formTeDoen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.lblTekstveld);
            this.Controls.Add(this.lblMessageBox);
            this.Controls.Add(this.btnTekstveld);
            this.Controls.Add(this.btnMessageBox);
            this.Controls.Add(this.dtpckTijd);
            this.Controls.Add(this.tbTekstVeld);
            this.Controls.Add(this.btnAchteraan);
            this.Controls.Add(this.btnTaakAfgewerkt);
            this.Controls.Add(this.btnTaakToevoegen);
            this.Controls.Add(this.btnTaakVolgende);
            this.Controls.Add(this.lblInformatie);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbInformatie);
            this.Controls.Add(this.tbTitel);
            this.Name = "formTeDoen";
            this.Text = "TeDoen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbTitel;
        private TextBox tbInformatie;
        private CheckBox checkBox1;
        private Label lblTitel;
        private Label lblInformatie;
        private Button btnTaakVolgende;
        private Button btnTaakToevoegen;
        private Button btnTaakAfgewerkt;
        private Button btnAchteraan;
        private TextBox tbTekstVeld;
        private DateTimePicker dtpckTijd;
        private Button btnMessageBox;
        private Button btnTekstveld;
        private Label lblMessageBox;
        private Label lblTekstveld;
    }
}