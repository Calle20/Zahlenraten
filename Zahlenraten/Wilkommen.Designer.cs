
namespace Zahlenraten
{
    partial class Wilkommen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wilkommen));
            this.Erklärung = new System.Windows.Forms.Label();
            this.Hallo = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.cb_nicht_mehr_anzeigen = new System.Windows.Forms.CheckBox();
            this.toolTipFenster = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipOK = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Erklärung
            // 
            resources.ApplyResources(this.Erklärung, "Erklärung");
            this.Erklärung.Name = "Erklärung";
            // 
            // Hallo
            // 
            resources.ApplyResources(this.Hallo, "Hallo");
            this.Hallo.ForeColor = System.Drawing.Color.Navy;
            this.Hallo.Name = "Hallo";
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.OK, "OK");
            this.OK.Name = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // cb_nicht_mehr_anzeigen
            // 
            resources.ApplyResources(this.cb_nicht_mehr_anzeigen, "cb_nicht_mehr_anzeigen");
            this.cb_nicht_mehr_anzeigen.Name = "cb_nicht_mehr_anzeigen";
            this.toolTipFenster.SetToolTip(this.cb_nicht_mehr_anzeigen, resources.GetString("cb_nicht_mehr_anzeigen.ToolTip"));
            this.cb_nicht_mehr_anzeigen.UseVisualStyleBackColor = true;
            // 
            // toolTipFenster
            // 
            this.toolTipFenster.AutoPopDelay = 5000;
            this.toolTipFenster.InitialDelay = 200;
            this.toolTipFenster.IsBalloon = true;
            this.toolTipFenster.ReshowDelay = 100;
            this.toolTipFenster.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipFenster.ToolTipTitle = "Fenster beim nächsten Programmstart (nicht mehr) zeigen";
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
            // Wilkommen
            // 
            this.AcceptButton = this.OK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ControlBox = false;
            this.Controls.Add(this.cb_nicht_mehr_anzeigen);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Hallo);
            this.Controls.Add(this.Erklärung);
            this.Name = "Wilkommen";
            this.Load += new System.EventHandler(this.Wilkommen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Erklärung;
        private System.Windows.Forms.Label Hallo;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.CheckBox cb_nicht_mehr_anzeigen;
        private System.Windows.Forms.ToolTip toolTipFenster;
        private System.Windows.Forms.ToolTip toolTipOK;
    }
}