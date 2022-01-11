
namespace Zahlenraten
{
    partial class Einstellungen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Einstellungen));
            this.OK = new System.Windows.Forms.Button();
            this.Alles_Zurücksetzen = new System.Windows.Forms.Button();
            this.TippsWiedAnzeig = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolTipOK = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTippsAnzeig = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHintFarbÄnd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAllesReseten = new System.Windows.Forms.ToolTip(this.components);
            this.tabC_Settings = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.tabPageSounds = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbIncorrectSound = new System.Windows.Forms.CheckBox();
            this.cbWrongSound = new System.Windows.Forms.CheckBox();
            this.cbRightSound = new System.Windows.Forms.CheckBox();
            this.tabPageBackround = new System.Windows.Forms.TabPage();
            this.tabC_Settings.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPageSounds.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Lime;
            this.OK.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(5, 148);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(254, 40);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.toolTipOK.SetToolTip(this.OK, "Schließt das Fenster und kehrt zurück zum Startmenü");
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Alles_Zurücksetzen
            // 
            this.Alles_Zurücksetzen.BackColor = System.Drawing.Color.Red;
            this.Alles_Zurücksetzen.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alles_Zurücksetzen.Location = new System.Drawing.Point(16, 67);
            this.Alles_Zurücksetzen.Name = "Alles_Zurücksetzen";
            this.Alles_Zurücksetzen.Size = new System.Drawing.Size(221, 40);
            this.Alles_Zurücksetzen.TabIndex = 1;
            this.Alles_Zurücksetzen.Text = "Alles Zurücksetzen";
            this.toolTipAllesReseten.SetToolTip(this.Alles_Zurücksetzen, "Setzt alles zurück (Highscore, Hintergrundfarbe usw...) und schließt das Spiel.");
            this.Alles_Zurücksetzen.UseVisualStyleBackColor = false;
            this.Alles_Zurücksetzen.Click += new System.EventHandler(this.Alles_Zurücksetzen_Click);
            // 
            // TippsWiedAnzeig
            // 
            this.TippsWiedAnzeig.BackColor = System.Drawing.SystemColors.Control;
            this.TippsWiedAnzeig.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TippsWiedAnzeig.Location = new System.Drawing.Point(16, 6);
            this.TippsWiedAnzeig.Name = "TippsWiedAnzeig";
            this.TippsWiedAnzeig.Size = new System.Drawing.Size(221, 40);
            this.TippsWiedAnzeig.TabIndex = 1;
            this.TippsWiedAnzeig.Text = "Tipps wieder anzeigen";
            this.toolTipTippsAnzeig.SetToolTip(this.TippsWiedAnzeig, "Aktiviert/Deaktiviert das Anzeigen von Tipps");
            this.TippsWiedAnzeig.UseVisualStyleBackColor = false;
            this.TippsWiedAnzeig.Click += new System.EventHandler(this.TippsWiedAnzeigen_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.Color = System.Drawing.Color.Turquoise;
            this.colorDialog.FullOpen = true;
            this.colorDialog.ShowHelp = true;
            this.colorDialog.HelpRequest += new System.EventHandler(this.colorDialog_HelpRequest);
            // 
            // toolTipOK
            // 
            this.toolTipOK.Active = false;
            this.toolTipOK.AutoPopDelay = 5000;
            this.toolTipOK.InitialDelay = 200;
            this.toolTipOK.IsBalloon = true;
            this.toolTipOK.ReshowDelay = 100;
            this.toolTipOK.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipOK.ToolTipTitle = "OK";
            // 
            // toolTipTippsAnzeig
            // 
            this.toolTipTippsAnzeig.Active = false;
            this.toolTipTippsAnzeig.AutoPopDelay = 5000;
            this.toolTipTippsAnzeig.InitialDelay = 200;
            this.toolTipTippsAnzeig.IsBalloon = true;
            this.toolTipTippsAnzeig.ReshowDelay = 100;
            this.toolTipTippsAnzeig.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipTippsAnzeig.ToolTipTitle = "Tipps aktivieren/deaktivieren";
            // 
            // toolTipHintFarbÄnd
            // 
            this.toolTipHintFarbÄnd.Active = false;
            this.toolTipHintFarbÄnd.AutoPopDelay = 5000;
            this.toolTipHintFarbÄnd.InitialDelay = 200;
            this.toolTipHintFarbÄnd.IsBalloon = true;
            this.toolTipHintFarbÄnd.ReshowDelay = 100;
            this.toolTipHintFarbÄnd.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHintFarbÄnd.ToolTipTitle = "Hintergrundfarbe ändern";
            // 
            // toolTipAllesReseten
            // 
            this.toolTipAllesReseten.Active = false;
            this.toolTipAllesReseten.AutoPopDelay = 5000;
            this.toolTipAllesReseten.InitialDelay = 200;
            this.toolTipAllesReseten.IsBalloon = true;
            this.toolTipAllesReseten.ReshowDelay = 100;
            this.toolTipAllesReseten.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipAllesReseten.ToolTipTitle = "Alles Zurücksetzen";
            // 
            // tabC_Settings
            // 
            this.tabC_Settings.Controls.Add(this.tabPageGeneral);
            this.tabC_Settings.Controls.Add(this.tabPageSounds);
            this.tabC_Settings.Controls.Add(this.tabPageBackround);
            this.tabC_Settings.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabC_Settings.Location = new System.Drawing.Point(1, 1);
            this.tabC_Settings.Name = "tabC_Settings";
            this.tabC_Settings.SelectedIndex = 0;
            this.tabC_Settings.Size = new System.Drawing.Size(262, 141);
            this.tabC_Settings.TabIndex = 5;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageGeneral.Controls.Add(this.Alles_Zurücksetzen);
            this.tabPageGeneral.Controls.Add(this.TippsWiedAnzeig);
            this.tabPageGeneral.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 24);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(254, 113);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Allgemein";
            this.tabPageGeneral.Enter += new System.EventHandler(this.tabPageGeneral_Enter);
            // 
            // tabPageSounds
            // 
            this.tabPageSounds.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSounds.Controls.Add(this.groupBox1);
            this.tabPageSounds.Location = new System.Drawing.Point(4, 24);
            this.tabPageSounds.Name = "tabPageSounds";
            this.tabPageSounds.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSounds.Size = new System.Drawing.Size(254, 113);
            this.tabPageSounds.TabIndex = 1;
            this.tabPageSounds.Text = "Sounds";
            this.tabPageSounds.Enter += new System.EventHandler(this.tabPageSounds_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbIncorrectSound);
            this.groupBox1.Controls.Add(this.cbWrongSound);
            this.groupBox1.Controls.Add(this.cbRightSound);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 105);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SFX";
            // 
            // cbIncorrectSound
            // 
            this.cbIncorrectSound.AutoSize = true;
            this.cbIncorrectSound.Checked = true;
            this.cbIncorrectSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIncorrectSound.Location = new System.Drawing.Point(6, 53);
            this.cbIncorrectSound.Name = "cbIncorrectSound";
            this.cbIncorrectSound.Size = new System.Drawing.Size(136, 22);
            this.cbIncorrectSound.TabIndex = 6;
            this.cbIncorrectSound.Text = "Keine gültige Zahl";
            this.cbIncorrectSound.UseVisualStyleBackColor = true;
            this.cbIncorrectSound.CheckedChanged += new System.EventHandler(this.cbIncorrectSound_CheckedChanged);
            // 
            // cbWrongSound
            // 
            this.cbWrongSound.AutoSize = true;
            this.cbWrongSound.Checked = true;
            this.cbWrongSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWrongSound.Location = new System.Drawing.Point(6, 81);
            this.cbWrongSound.Name = "cbWrongSound";
            this.cbWrongSound.Size = new System.Drawing.Size(180, 22);
            this.cbWrongSound.TabIndex = 7;
            this.cbWrongSound.Text = "Alle Versuche verbraucht";
            this.cbWrongSound.UseVisualStyleBackColor = true;
            this.cbWrongSound.CheckedChanged += new System.EventHandler(this.cbWrongSound_CheckedChanged);
            // 
            // cbRightSound
            // 
            this.cbRightSound.AutoSize = true;
            this.cbRightSound.Checked = true;
            this.cbRightSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRightSound.Location = new System.Drawing.Point(6, 25);
            this.cbRightSound.Name = "cbRightSound";
            this.cbRightSound.Size = new System.Drawing.Size(69, 22);
            this.cbRightSound.TabIndex = 4;
            this.cbRightSound.Text = "Richtig";
            this.cbRightSound.UseVisualStyleBackColor = true;
            this.cbRightSound.CheckedChanged += new System.EventHandler(this.cbRightSound_CheckedChanged);
            // 
            // tabPageBackround
            // 
            this.tabPageBackround.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageBackround.Location = new System.Drawing.Point(4, 24);
            this.tabPageBackround.Name = "tabPageBackround";
            this.tabPageBackround.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBackround.Size = new System.Drawing.Size(254, 113);
            this.tabPageBackround.TabIndex = 2;
            this.tabPageBackround.Text = "Hintergrundfarbe ändern";
            this.tabPageBackround.Enter += new System.EventHandler(this.tabPageBackround_Enter);
            // 
            // Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(266, 195);
            this.Controls.Add(this.tabC_Settings);
            this.Controls.Add(this.OK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(395, 474);
            this.Name = "Einstellungen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.Einstellungen_Load);
            this.tabC_Settings.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageSounds.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Alles_Zurücksetzen;
        private System.Windows.Forms.Button TippsWiedAnzeig;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolTip toolTipOK;
        private System.Windows.Forms.ToolTip toolTipTippsAnzeig;
        private System.Windows.Forms.ToolTip toolTipHintFarbÄnd;
        private System.Windows.Forms.ToolTip toolTipAllesReseten;
        private System.Windows.Forms.TabControl tabC_Settings;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageSounds;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbIncorrectSound;
        private System.Windows.Forms.CheckBox cbWrongSound;
        private System.Windows.Forms.CheckBox cbRightSound;
        private System.Windows.Forms.TabPage tabPageBackround;
    }
}