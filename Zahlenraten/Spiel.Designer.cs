namespace Zahlenraten
{
    partial class Spiel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spiel));
            this.Zahlen = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hallo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTipZahl = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipNochmal = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBeenden = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Zahlen
            // 
            this.Zahlen.AutoSize = true;
            this.Zahlen.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zahlen.ForeColor = System.Drawing.Color.Black;
            this.Zahlen.Location = new System.Drawing.Point(190, 147);
            this.Zahlen.Name = "Zahlen";
            this.Zahlen.Size = new System.Drawing.Size(775, 38);
            this.Zahlen.TabIndex = 1;
            this.Zahlen.Text = "Ich denke mir eine Zahl zwischen 1 und 100. Welche ist es?\"";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(421, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 45);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.MouseHover += new System.EventHandler(this.TextBox1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(279, 270);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(621, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Schade du hast alle deine Versuche verbraucht.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hallo
            // 
            this.Hallo.AutoSize = true;
            this.Hallo.Font = new System.Drawing.Font("Comic Sans MS", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hallo.ForeColor = System.Drawing.Color.Navy;
            this.Hallo.Location = new System.Drawing.Point(12, 27);
            this.Hallo.Name = "Hallo";
            this.Hallo.Size = new System.Drawing.Size(1135, 84);
            this.Hallo.TabIndex = 5;
            this.Hallo.Text = "Herzlich Willkommen beim Zahlenraten";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(338, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Versuchs am besten gleich noch einmal.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Du hast noch 2 Versuche.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 38);
            this.label4.TabIndex = 10;
            this.label4.Text = "Die gesuchte Zahlist größer.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "Du hast noch einen Versuch!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "Das ist richtig!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(360, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(457, 38);
            this.label7.TabIndex = 13;
            this.label7.Text = "Die richtige Zahl wäre 99 gewesen!";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(421, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(307, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Nochmal";
            this.toolTipNochmal.SetToolTip(this.button2, "Öffnet wieder die Startseite und\r\nsie können ein neues Spiel starten.");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(421, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(307, 45);
            this.button3.TabIndex = 8;
            this.button3.Text = "Beenden";
            this.toolTipBeenden.SetToolTip(this.button3, "Schließt alles und beendet Zahlenraten.");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(434, 38);
            this.label8.TabIndex = 14;
            this.label8.Text = "Du hattest keinen Versuch mehr.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1, 1);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // toolTipZahl
            // 
            this.toolTipZahl.AutoPopDelay = 5000;
            this.toolTipZahl.InitialDelay = 200;
            this.toolTipZahl.IsBalloon = true;
            this.toolTipZahl.ReshowDelay = 100;
            this.toolTipZahl.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipZahl.ToolTipTitle = "Zahl eingeben";
            // 
            // toolTipNochmal
            // 
            this.toolTipNochmal.AutoPopDelay = 5000;
            this.toolTipNochmal.InitialDelay = 200;
            this.toolTipNochmal.IsBalloon = true;
            this.toolTipNochmal.ReshowDelay = 100;
            this.toolTipNochmal.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipNochmal.ToolTipTitle = "Nochmal";
            // 
            // toolTipBeenden
            // 
            this.toolTipBeenden.AutoPopDelay = 5000;
            this.toolTipBeenden.InitialDelay = 200;
            this.toolTipBeenden.IsBalloon = true;
            this.toolTipBeenden.ReshowDelay = 100;
            this.toolTipBeenden.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipBeenden.ToolTipTitle = "Beenden";
            // 
            // Spiel
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1156, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hallo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Zahlen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Spiel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zahlenraten";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Zahlen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Hallo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTipZahl;
        private System.Windows.Forms.ToolTip toolTipNochmal;
        private System.Windows.Forms.ToolTip toolTipBeenden;
    }
}