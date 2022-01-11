namespace Zahlenraten
{
    partial class Warnung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warnung));
            this.OK = new System.Windows.Forms.Button();
            this.ZuGroß = new System.Windows.Forms.Label();
            this.Versuch = new System.Windows.Forms.TextBox();
            this.KeineZahl = new System.Windows.Forms.Label();
            this.toolTipOK = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipVersuch = new System.Windows.Forms.ToolTip(this.components);
            this.GroßBereich = new System.Windows.Forms.Label();
            this.Klein = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Lime;
            this.OK.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(12, 140);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(244, 39);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.toolTipOK.SetToolTip(this.OK, "Schließt das Fenster und startet das Spiel");
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ZuGroß
            // 
            this.ZuGroß.AutoSize = true;
            this.ZuGroß.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZuGroß.Location = new System.Drawing.Point(12, 9);
            this.ZuGroß.Name = "ZuGroß";
            this.ZuGroß.Size = new System.Drawing.Size(254, 92);
            this.ZuGroß.TabIndex = 0;
            this.ZuGroß.Text = "    Deine Anzahl an Versuchen \r\nist gößer als dein Zahlenbereich.\r\nBitte gib eine" +
    " kleinere Anzahl an \r\nVersuchen an und drücke auf OK.";
            this.ZuGroß.Visible = false;
            // 
            // Versuch
            // 
            this.Versuch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Versuch.Location = new System.Drawing.Point(12, 104);
            this.Versuch.Name = "Versuch";
            this.Versuch.Size = new System.Drawing.Size(244, 30);
            this.Versuch.TabIndex = 0;
            this.Versuch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeineZahl
            // 
            this.KeineZahl.AutoSize = true;
            this.KeineZahl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeineZahl.Location = new System.Drawing.Point(12, 20);
            this.KeineZahl.Name = "KeineZahl";
            this.KeineZahl.Size = new System.Drawing.Size(240, 69);
            this.KeineZahl.TabIndex = 0;
            this.KeineZahl.Text = "         Du hast keine Zahl\r\n eingegeben. Bitte gib eine Zahl\r\n       ein und drü" +
    "cke auf OK.";
            this.KeineZahl.Visible = false;
            // 
            // toolTipOK
            // 
            this.toolTipOK.AutoPopDelay = 5000;
            this.toolTipOK.InitialDelay = 200;
            this.toolTipOK.IsBalloon = true;
            this.toolTipOK.ReshowDelay = 100;
            this.toolTipOK.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipOK.ToolTipTitle = "OK";
            // 
            // toolTipVersuch
            // 
            this.toolTipVersuch.AutoPopDelay = 5000;
            this.toolTipVersuch.InitialDelay = 200;
            this.toolTipVersuch.IsBalloon = true;
            this.toolTipVersuch.ReshowDelay = 100;
            this.toolTipVersuch.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipVersuch.ToolTipTitle = "Zahl eingeben";
            // 
            // GroßBereich
            // 
            this.GroßBereich.AutoSize = true;
            this.GroßBereich.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroßBereich.Location = new System.Drawing.Point(25, 9);
            this.GroßBereich.Name = "GroßBereich";
            this.GroßBereich.Size = new System.Drawing.Size(227, 92);
            this.GroßBereich.TabIndex = 2;
            this.GroßBereich.Text = "    Achtung! Deine Zahl ist\r\ngrößer als dein Zahlenbereich\r\n  Bitte gib eine klei" +
    "nere Zahl\r\n     ein und drücke auf OK";
            this.GroßBereich.Visible = false;
            // 
            // Klein
            // 
            this.Klein.AutoSize = true;
            this.Klein.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klein.Location = new System.Drawing.Point(8, 9);
            this.Klein.Name = "Klein";
            this.Klein.Size = new System.Drawing.Size(258, 92);
            this.Klein.TabIndex = 3;
            this.Klein.Text = "Achtung! Du hast 0 eingegeben. \r\nNull liegt nicht im Zahlenbereich\r\n1-100. Bitte " +
    "gib eine größere Zahl\r\nein und drücke auf OK.";
            this.Klein.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Klein.Visible = false;
            // 
            // Warnung
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(266, 188);
            this.ControlBox = false;
            this.Controls.Add(this.Klein);
            this.Controls.Add(this.GroßBereich);
            this.Controls.Add(this.KeineZahl);
            this.Controls.Add(this.Versuch);
            this.Controls.Add(this.ZuGroß);
            this.Controls.Add(this.OK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Warnung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warnung";
            this.Load += new System.EventHandler(this.Warnung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label ZuGroß;
        private System.Windows.Forms.TextBox Versuch;
        private System.Windows.Forms.Label KeineZahl;
        private System.Windows.Forms.ToolTip toolTipOK;
        private System.Windows.Forms.ToolTip toolTipVersuch;
        private System.Windows.Forms.Label GroßBereich;
        private System.Windows.Forms.Label Klein;
    }
}