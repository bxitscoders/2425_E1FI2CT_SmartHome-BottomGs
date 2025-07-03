namespace Variablen
{
    partial class Personaldaten
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
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.btnVN = new System.Windows.Forms.Button();
            this.btnNN = new System.Windows.Forms.Button();
            this.btnGeb = new System.Windows.Forms.Button();
            this.btnOrt = new System.Windows.Forms.Button();
            this.gbxAusgabe = new System.Windows.Forms.GroupBox();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.gbxVerarbeitung = new System.Windows.Forms.GroupBox();
            this.btnGehaltHoch = new System.Windows.Forms.Button();
            this.btnGenerieren = new System.Windows.Forms.Button();
            this.lblEing = new System.Windows.Forms.Label();
            this.gbxEingabe = new System.Windows.Forms.GroupBox();
            this.btnGehalt = new System.Windows.Forms.Button();
            this.btnAbteilung = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxAusgabe.SuspendLayout();
            this.gbxVerarbeitung.SuspendLayout();
            this.gbxEingabe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(136, 28);
            this.txtEingabe.Margin = new System.Windows.Forms.Padding(4);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(380, 22);
            this.txtEingabe.TabIndex = 0;
            // 
            // btnVN
            // 
            this.btnVN.Location = new System.Drawing.Point(136, 60);
            this.btnVN.Margin = new System.Windows.Forms.Padding(4);
            this.btnVN.Name = "btnVN";
            this.btnVN.Size = new System.Drawing.Size(187, 52);
            this.btnVN.TabIndex = 1;
            this.btnVN.Text = "Vorname speichern";
            this.btnVN.UseVisualStyleBackColor = true;
            this.btnVN.Click += new System.EventHandler(this.btnVN_Click);
            // 
            // btnNN
            // 
            this.btnNN.Location = new System.Drawing.Point(331, 60);
            this.btnNN.Margin = new System.Windows.Forms.Padding(4);
            this.btnNN.Name = "btnNN";
            this.btnNN.Size = new System.Drawing.Size(187, 52);
            this.btnNN.TabIndex = 1;
            this.btnNN.Text = "Nachname speichern";
            this.btnNN.UseVisualStyleBackColor = true;
            this.btnNN.Click += new System.EventHandler(this.btnNN_Click);
            // 
            // btnGeb
            // 
            this.btnGeb.Location = new System.Drawing.Point(136, 119);
            this.btnGeb.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeb.Name = "btnGeb";
            this.btnGeb.Size = new System.Drawing.Size(187, 52);
            this.btnGeb.TabIndex = 1;
            this.btnGeb.Text = "Geburtsjahr speichern";
            this.btnGeb.UseVisualStyleBackColor = true;
            this.btnGeb.Click += new System.EventHandler(this.btnGeb_Click);
            // 
            // btnOrt
            // 
            this.btnOrt.Location = new System.Drawing.Point(331, 119);
            this.btnOrt.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrt.Name = "btnOrt";
            this.btnOrt.Size = new System.Drawing.Size(187, 52);
            this.btnOrt.TabIndex = 1;
            this.btnOrt.Text = "Ort speichern";
            this.btnOrt.UseVisualStyleBackColor = true;
            this.btnOrt.Click += new System.EventHandler(this.btnOrt_Click);
            // 
            // gbxAusgabe
            // 
            this.gbxAusgabe.Controls.Add(this.lblAusgabe);
            this.gbxAusgabe.Location = new System.Drawing.Point(17, 358);
            this.gbxAusgabe.Margin = new System.Windows.Forms.Padding(4);
            this.gbxAusgabe.Name = "gbxAusgabe";
            this.gbxAusgabe.Padding = new System.Windows.Forms.Padding(4);
            this.gbxAusgabe.Size = new System.Drawing.Size(771, 85);
            this.gbxAusgabe.TabIndex = 2;
            this.gbxAusgabe.TabStop = false;
            this.gbxAusgabe.Text = "Ausgabe";
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Location = new System.Drawing.Point(23, 34);
            this.lblAusgabe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(72, 17);
            this.lblAusgabe.TabIndex = 0;
            this.lblAusgabe.Text = "Datensatz";
            // 
            // gbxVerarbeitung
            // 
            this.gbxVerarbeitung.Controls.Add(this.btnGehaltHoch);
            this.gbxVerarbeitung.Controls.Add(this.btnGenerieren);
            this.gbxVerarbeitung.Location = new System.Drawing.Point(17, 266);
            this.gbxVerarbeitung.Margin = new System.Windows.Forms.Padding(4);
            this.gbxVerarbeitung.Name = "gbxVerarbeitung";
            this.gbxVerarbeitung.Padding = new System.Windows.Forms.Padding(4);
            this.gbxVerarbeitung.Size = new System.Drawing.Size(771, 85);
            this.gbxVerarbeitung.TabIndex = 2;
            this.gbxVerarbeitung.TabStop = false;
            this.gbxVerarbeitung.Text = "Verarbeitung";
            // 
            // btnGehaltHoch
            // 
            this.btnGehaltHoch.Location = new System.Drawing.Point(8, 25);
            this.btnGehaltHoch.Name = "btnGehaltHoch";
            this.btnGehaltHoch.Size = new System.Drawing.Size(228, 41);
            this.btnGehaltHoch.TabIndex = 1;
            this.btnGehaltHoch.Text = "Gehalt um 5% erhöhen";
            this.btnGehaltHoch.UseVisualStyleBackColor = true;
            this.btnGehaltHoch.Click += new System.EventHandler(this.btnGehaltHoch_Click);
            // 
            // btnGenerieren
            // 
            this.btnGenerieren.Location = new System.Drawing.Point(481, 25);
            this.btnGenerieren.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerieren.Name = "btnGenerieren";
            this.btnGenerieren.Size = new System.Drawing.Size(282, 41);
            this.btnGenerieren.TabIndex = 0;
            this.btnGenerieren.Text = "Datensatz generieren und ausgeben";
            this.btnGenerieren.UseVisualStyleBackColor = true;
            this.btnGenerieren.Click += new System.EventHandler(this.btnGenerieren_Click);
            // 
            // lblEing
            // 
            this.lblEing.AutoSize = true;
            this.lblEing.Location = new System.Drawing.Point(5, 32);
            this.lblEing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEing.Name = "lblEing";
            this.lblEing.Size = new System.Drawing.Size(122, 17);
            this.lblEing.TabIndex = 3;
            this.lblEing.Text = "Universaleingabe:";
            // 
            // gbxEingabe
            // 
            this.gbxEingabe.Controls.Add(this.btnVN);
            this.gbxEingabe.Controls.Add(this.lblEing);
            this.gbxEingabe.Controls.Add(this.txtEingabe);
            this.gbxEingabe.Controls.Add(this.btnNN);
            this.gbxEingabe.Controls.Add(this.btnGehalt);
            this.gbxEingabe.Controls.Add(this.btnAbteilung);
            this.gbxEingabe.Controls.Add(this.btnGeb);
            this.gbxEingabe.Controls.Add(this.btnOrt);
            this.gbxEingabe.Location = new System.Drawing.Point(25, 15);
            this.gbxEingabe.Margin = new System.Windows.Forms.Padding(4);
            this.gbxEingabe.Name = "gbxEingabe";
            this.gbxEingabe.Padding = new System.Windows.Forms.Padding(4);
            this.gbxEingabe.Size = new System.Drawing.Size(540, 244);
            this.gbxEingabe.TabIndex = 4;
            this.gbxEingabe.TabStop = false;
            this.gbxEingabe.Text = "Eingabe";
            // 
            // btnGehalt
            // 
            this.btnGehalt.Location = new System.Drawing.Point(331, 178);
            this.btnGehalt.Margin = new System.Windows.Forms.Padding(4);
            this.btnGehalt.Name = "btnGehalt";
            this.btnGehalt.Size = new System.Drawing.Size(187, 52);
            this.btnGehalt.TabIndex = 1;
            this.btnGehalt.Text = "Gehalt speichern";
            this.btnGehalt.UseVisualStyleBackColor = true;
            this.btnGehalt.Click += new System.EventHandler(this.btnGehalt_Click);
            // 
            // btnAbteilung
            // 
            this.btnAbteilung.Location = new System.Drawing.Point(136, 178);
            this.btnAbteilung.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbteilung.Name = "btnAbteilung";
            this.btnAbteilung.Size = new System.Drawing.Size(187, 52);
            this.btnAbteilung.TabIndex = 1;
            this.btnAbteilung.Text = "Abteilung speichern";
            this.btnAbteilung.UseVisualStyleBackColor = true;
            this.btnAbteilung.Click += new System.EventHandler(this.btnAbteilung_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Variablen.Properties.Resources.angestellter;
            this.pictureBox1.Location = new System.Drawing.Point(589, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 232);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Personaldaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxEingabe);
            this.Controls.Add(this.gbxVerarbeitung);
            this.Controls.Add(this.gbxAusgabe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Personaldaten";
            this.Text = "Personaldaten";
            this.gbxAusgabe.ResumeLayout(false);
            this.gbxAusgabe.PerformLayout();
            this.gbxVerarbeitung.ResumeLayout(false);
            this.gbxEingabe.ResumeLayout(false);
            this.gbxEingabe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEingabe;
        private System.Windows.Forms.Button btnVN;
        private System.Windows.Forms.Button btnNN;
        private System.Windows.Forms.Button btnGeb;
        private System.Windows.Forms.Button btnOrt;
        private System.Windows.Forms.GroupBox gbxAusgabe;
        private System.Windows.Forms.Label lblAusgabe;
        private System.Windows.Forms.GroupBox gbxVerarbeitung;
        private System.Windows.Forms.Button btnGenerieren;
        private System.Windows.Forms.Label lblEing;
        private System.Windows.Forms.GroupBox gbxEingabe;
        private System.Windows.Forms.Button btnGehalt;
        private System.Windows.Forms.Button btnAbteilung;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGehaltHoch;
    }
}

