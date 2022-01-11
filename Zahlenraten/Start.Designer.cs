namespace Zahlenraten
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Hallo = new System.Windows.Forms.Label();
            this.Versuch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEinstellungen = new System.Windows.Forms.Button();
            this.Highscore = new System.Windows.Forms.Button();
            this.toolTipZahlenbereichAuswählen = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipStart = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHighscore = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEinstellungen = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipVersuche = new System.Windows.Forms.ToolTip(this.components);
            this.radioButtonLeicht = new System.Windows.Forms.RadioButton();
            this.radioButtonSchwer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hallo
            // 
            this.Hallo.AutoSize = true;
            this.Hallo.Font = new System.Drawing.Font("Comic Sans MS", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hallo.ForeColor = System.Drawing.Color.Navy;
            this.Hallo.Location = new System.Drawing.Point(12, 27);
            this.Hallo.Name = "Hallo";
            this.Hallo.Size = new System.Drawing.Size(1135, 84);
            this.Hallo.TabIndex = 1;
            this.Hallo.Text = "Herzlich Willkommen beim Zahlenraten";
            // 
            // Versuch
            // 
            this.Versuch.BackColor = System.Drawing.SystemColors.Window;
            this.Versuch.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Versuch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Versuch.Location = new System.Drawing.Point(433, 174);
            this.Versuch.Name = "Versuch";
            this.Versuch.Size = new System.Drawing.Size(307, 45);
            this.Versuch.TabIndex = 0;
            this.Versuch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mit wie vielen Versuchen möchtest du spielen?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(522, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Wähle deinen Zahlenbereich zum Raten!";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(161, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "1-10";
            this.toolTipZahlenbereichAuswählen.SetToolTip(this.button2, "Wählt den Zahlenbereich 1-10 aus. Das heißt, \r\ndass die zu ratende Zahl zwischen " +
        "1 und 10 liegt.");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(334, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 51);
            this.button3.TabIndex = 10;
            this.button3.Text = "1-25";
            this.toolTipZahlenbereichAuswählen.SetToolTip(this.button3, "Wählt den Zahlenbereich 1-25 aus. Das heißt,\r\ndass die zu ratende Zahl zwischen 1" +
        " und 25 liegt.");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(508, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 51);
            this.button4.TabIndex = 7;
            this.button4.Text = "1-50";
            this.toolTipZahlenbereichAuswählen.SetToolTip(this.button4, "Wählt den Zahlenbereich 1-50 aus. Das heißt,\r\ndass die zu ratende Zahl zwischen 1" +
        " und 50 liegt.");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(686, 394);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 51);
            this.button5.TabIndex = 6;
            this.button5.Text = "1-75";
            this.toolTipZahlenbereichAuswählen.SetToolTip(this.button5, "Wählt den Zahlenbereich 1-75 aus. Das heißt,\r\ndass die zu ratende Zahl zwischen 1" +
        " und 75 liegt.");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(863, 394);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 51);
            this.button6.TabIndex = 6;
            this.button6.Text = "1-100";
            this.toolTipZahlenbereichAuswählen.SetToolTip(this.button6, "Wählt den Zahlenbereich 1-100 aus. Das heißt, dass die zu ratende Zahl zwischen 1" +
        " und 100 liegt.");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(377, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(406, 62);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "Start";
            this.toolTipStart.SetToolTip(this.button1, "Wenn alle notwendigen Einstellungen (Versuche, Zahlenbereich) \r\nvorgenommen wurde" +
        "n, kann hier das Spiel gestartet werden.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEinstellungen
            // 
            this.btnEinstellungen.FlatAppearance.BorderSize = 0;
            this.btnEinstellungen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEinstellungen.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEinstellungen.Location = new System.Drawing.Point(26, 482);
            this.btnEinstellungen.Name = "btnEinstellungen";
            this.btnEinstellungen.Size = new System.Drawing.Size(234, 43);
            this.btnEinstellungen.TabIndex = 2;
            this.btnEinstellungen.TabStop = false;
            this.btnEinstellungen.Text = "Einstellungen";
            this.toolTipEinstellungen.SetToolTip(this.btnEinstellungen, "Öffnet ein Fenster um Einstellungen (z.B. um das Anzeigen von Tipps zu aktivieren" +
        "/deaktivieren,\r\num alles zurückzusetzten, um die Wilkommensseite anzeigen) vorzu" +
        "nehmen.");
            this.btnEinstellungen.UseVisualStyleBackColor = true;
            this.btnEinstellungen.Click += new System.EventHandler(this.Einstellungen_Click);
            // 
            // Highscore
            // 
            this.Highscore.FlatAppearance.BorderSize = 0;
            this.Highscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Highscore.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Highscore.Location = new System.Drawing.Point(882, 482);
            this.Highscore.Name = "Highscore";
            this.Highscore.Size = new System.Drawing.Size(234, 43);
            this.Highscore.TabIndex = 3;
            this.Highscore.TabStop = false;
            this.Highscore.Text = "Highscore";
            this.toolTipHighscore.SetToolTip(this.Highscore, "Öffnet ein Fenster um deinen Highscore anzuzeigen.\r\n\r\n");
            this.Highscore.UseVisualStyleBackColor = true;
            this.Highscore.Click += new System.EventHandler(this.Highscore_Click);
            // 
            // toolTipZahlenbereichAuswählen
            // 
            this.toolTipZahlenbereichAuswählen.AutoPopDelay = 5000;
            this.toolTipZahlenbereichAuswählen.InitialDelay = 200;
            this.toolTipZahlenbereichAuswählen.IsBalloon = true;
            this.toolTipZahlenbereichAuswählen.ReshowDelay = 100;
            this.toolTipZahlenbereichAuswählen.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipZahlenbereichAuswählen.ToolTipTitle = "Zahlenbereich auswählen";
            // 
            // toolTipStart
            // 
            this.toolTipStart.AutoPopDelay = 5000;
            this.toolTipStart.InitialDelay = 200;
            this.toolTipStart.IsBalloon = true;
            this.toolTipStart.ReshowDelay = 100;
            this.toolTipStart.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipStart.ToolTipTitle = "Start";
            // 
            // toolTipHighscore
            // 
            this.toolTipHighscore.AutoPopDelay = 5000;
            this.toolTipHighscore.InitialDelay = 200;
            this.toolTipHighscore.IsBalloon = true;
            this.toolTipHighscore.ReshowDelay = 100;
            this.toolTipHighscore.ShowAlways = true;
            this.toolTipHighscore.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHighscore.ToolTipTitle = "Highscore";
            // 
            // toolTipEinstellungen
            // 
            this.toolTipEinstellungen.AutoPopDelay = 5000;
            this.toolTipEinstellungen.InitialDelay = 200;
            this.toolTipEinstellungen.IsBalloon = true;
            this.toolTipEinstellungen.ReshowDelay = 100;
            this.toolTipEinstellungen.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipEinstellungen.ToolTipTitle = "Einstellungen";
            // 
            // toolTipVersuche
            // 
            this.toolTipVersuche.AutoPopDelay = 5000;
            this.toolTipVersuche.InitialDelay = 200;
            this.toolTipVersuche.IsBalloon = true;
            this.toolTipVersuche.ReshowDelay = 100;
            this.toolTipVersuche.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipVersuche.ToolTipTitle = "Versuche";
            // 
            // radioButtonLeicht
            // 
            this.radioButtonLeicht.AutoSize = true;
            this.radioButtonLeicht.Checked = true;
            this.radioButtonLeicht.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLeicht.Location = new System.Drawing.Point(6, 22);
            this.radioButtonLeicht.Name = "radioButtonLeicht";
            this.radioButtonLeicht.Size = new System.Drawing.Size(517, 50);
            this.radioButtonLeicht.TabIndex = 4;
            this.radioButtonLeicht.TabStop = true;
            this.radioButtonLeicht.Text = "Leicht: Wenn sie einen Zahlenbereich ausgewählt haben, wird dabei\r\n automatisch d" +
    "ie maximal mögliche Anzahl an Versuchen verwendet";
            this.radioButtonLeicht.UseVisualStyleBackColor = true;
            this.radioButtonLeicht.CheckedChanged += new System.EventHandler(this.RadioButtonLeicht_CheckedChanged);
            // 
            // radioButtonSchwer
            // 
            this.radioButtonSchwer.AutoSize = true;
            this.radioButtonSchwer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSchwer.Location = new System.Drawing.Point(523, 34);
            this.radioButtonSchwer.Name = "radioButtonSchwer";
            this.radioButtonSchwer.Size = new System.Drawing.Size(546, 27);
            this.radioButtonSchwer.TabIndex = 5;
            this.radioButtonSchwer.Text = "Schwer: Sie können selber die maximale Anzahl an Versuchen einstellen";
            this.radioButtonSchwer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonLeicht);
            this.groupBox1.Controls.Add(this.radioButtonSchwer);
            this.groupBox1.Location = new System.Drawing.Point(41, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1075, 81);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 442);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 40);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1156, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Highscore);
            this.Controls.Add(this.btnEinstellungen);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Versuch);
            this.Controls.Add(this.Hallo);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zahlenraten";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hallo;
        private System.Windows.Forms.TextBox Versuch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnEinstellungen;
        private System.Windows.Forms.Button Highscore;
        private System.Windows.Forms.ToolTip toolTipStart;
        private System.Windows.Forms.ToolTip toolTipHighscore;
        private System.Windows.Forms.ToolTip toolTipEinstellungen;
        private System.Windows.Forms.ToolTip toolTipVersuche;
        private System.Windows.Forms.RadioButton radioButtonLeicht;
        private System.Windows.Forms.RadioButton radioButtonSchwer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTipZahlenbereichAuswählen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

