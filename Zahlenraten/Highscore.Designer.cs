
namespace Zahlenraten
{
    partial class Highscore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Highscore));
            this.Hallo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Zurücksetzen1 = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Zurücksetzen2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Zurücksetzen3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Zurücksetzen4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Zurücksetzen5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTipZurücksetzen = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipOK = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hallo
            // 
            this.Hallo.AutoSize = true;
            this.Hallo.Font = new System.Drawing.Font("Comic Sans MS", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hallo.ForeColor = System.Drawing.Color.Navy;
            this.Hallo.Location = new System.Drawing.Point(224, 9);
            this.Hallo.Name = "Hallo";
            this.Hallo.Size = new System.Drawing.Size(319, 84);
            this.Hallo.TabIndex = 0;
            this.Hallo.Text = "Highscore";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = " 9 Versuche";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "1-10";
            // 
            // Zurücksetzen1
            // 
            this.Zurücksetzen1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zurücksetzen1.Location = new System.Drawing.Point(4, 75);
            this.Zurücksetzen1.Name = "Zurücksetzen1";
            this.Zurücksetzen1.Size = new System.Drawing.Size(129, 36);
            this.Zurücksetzen1.TabIndex = 19;
            this.Zurücksetzen1.Text = "Zurücksetzen";
            this.toolTipZurücksetzen.SetToolTip(this.Zurücksetzen1, "Setzt den Highscore für den Zahlennbereich von 1-10 zurück");
            this.Zurücksetzen1.UseVisualStyleBackColor = true;
            this.Zurücksetzen1.Click += new System.EventHandler(this.Zurücksetzen1_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Lime;
            this.OK.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(226, 216);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(293, 48);
            this.OK.TabIndex = 20;
            this.OK.Text = "OK";
            this.toolTipOK.SetToolTip(this.OK, "Schließt das Fenster und kehrt zurück zum Startmenü");
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Zurücksetzen1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 114);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Zurücksetzen2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(157, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 114);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // Zurücksetzen2
            // 
            this.Zurücksetzen2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zurücksetzen2.Location = new System.Drawing.Point(4, 75);
            this.Zurücksetzen2.Name = "Zurücksetzen2";
            this.Zurücksetzen2.Size = new System.Drawing.Size(129, 36);
            this.Zurücksetzen2.TabIndex = 19;
            this.Zurücksetzen2.Text = "Zurücksetzen";
            this.toolTipZurücksetzen.SetToolTip(this.Zurücksetzen2, "Setzt den Highscore für den Zahlennbereich von 1-25 zurück");
            this.Zurücksetzen2.UseVisualStyleBackColor = true;
            this.Zurücksetzen2.Click += new System.EventHandler(this.Zurücksetzen2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 26);
            this.label11.TabIndex = 3;
            this.label11.Text = "24 Versuche";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(43, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 28);
            this.label12.TabIndex = 13;
            this.label12.Text = "1-25";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Zurücksetzen3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(302, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 114);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // Zurücksetzen3
            // 
            this.Zurücksetzen3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zurücksetzen3.Location = new System.Drawing.Point(4, 75);
            this.Zurücksetzen3.Name = "Zurücksetzen3";
            this.Zurücksetzen3.Size = new System.Drawing.Size(129, 36);
            this.Zurücksetzen3.TabIndex = 19;
            this.Zurücksetzen3.Text = "Zurücksetzen";
            this.toolTipZurücksetzen.SetToolTip(this.Zurücksetzen3, "Setzt den Highscore für den Zahlennbereich von 1-50 zurück");
            this.Zurücksetzen3.UseVisualStyleBackColor = true;
            this.Zurücksetzen3.Click += new System.EventHandler(this.Zurücksetzen3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "59 Versuche";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "1-50";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Zurücksetzen4);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(447, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(139, 114);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            // 
            // Zurücksetzen4
            // 
            this.Zurücksetzen4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zurücksetzen4.Location = new System.Drawing.Point(4, 75);
            this.Zurücksetzen4.Name = "Zurücksetzen4";
            this.Zurücksetzen4.Size = new System.Drawing.Size(129, 36);
            this.Zurücksetzen4.TabIndex = 19;
            this.Zurücksetzen4.Text = "Zurücksetzen";
            this.toolTipZurücksetzen.SetToolTip(this.Zurücksetzen4, "Setzt den Highscore für den Zahlennbereich von 1-75 zurück");
            this.Zurücksetzen4.UseVisualStyleBackColor = true;
            this.Zurücksetzen4.Click += new System.EventHandler(this.Zurücksetzen4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "74 Versuche";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "1-75";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Zurücksetzen5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(592, 96);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(139, 114);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            // 
            // Zurücksetzen5
            // 
            this.Zurücksetzen5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zurücksetzen5.Location = new System.Drawing.Point(4, 75);
            this.Zurücksetzen5.Name = "Zurücksetzen5";
            this.Zurücksetzen5.Size = new System.Drawing.Size(129, 36);
            this.Zurücksetzen5.TabIndex = 19;
            this.Zurücksetzen5.Text = "Zurücksetzen";
            this.toolTipZurücksetzen.SetToolTip(this.Zurücksetzen5, "Setzt den Highscore für den Zahlennbereich von 1-100 zurück");
            this.Zurücksetzen5.UseVisualStyleBackColor = true;
            this.Zurücksetzen5.Click += new System.EventHandler(this.Zurücksetzen5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "99 Versuche";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "1-100";
            // 
            // toolTipZurücksetzen
            // 
            this.toolTipZurücksetzen.AutoPopDelay = 5000;
            this.toolTipZurücksetzen.InitialDelay = 200;
            this.toolTipZurücksetzen.IsBalloon = true;
            this.toolTipZurücksetzen.ReshowDelay = 100;
            this.toolTipZurücksetzen.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipZurücksetzen.ToolTipTitle = "Zurücksetzen";
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
            // Highscore
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(743, 275);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Hallo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Highscore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Highscore";
            this.Load += new System.EventHandler(this.Highscore_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hallo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Zurücksetzen1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Zurücksetzen2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Zurücksetzen3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Zurücksetzen4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Zurücksetzen5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTipZurücksetzen;
        private System.Windows.Forms.ToolTip toolTipOK;
    }
}