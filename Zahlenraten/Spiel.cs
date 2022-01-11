using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zahlenraten
{
    public partial class Spiel : Form
    {
        public Spiel()
        {
            InitializeComponent();
        }
        public static int Highscore { get; set; }
        public Form Form { get; set; }
        public static bool klein = false;
        public static int versuche { get; set; }

        public static bool Versuch_Abziehen = true;
        private void Form3_Load(object sender, EventArgs e)
        {
            versuche = 0;
            Zahlen.Text = "Ich denke mir eine Zahl zwischen 1 und " + Form1.Bereich + " . Welche ist es?";
            Labels_Clear();
            Form1.zahl = false;
            Form1.groß = false;
            Form1.vonForm1 = false;
            klein = false;
            AcceptButton = button1;
            BackColor = Properties.Settings.Default.Hintergrundfarbe;
            Tipps(Properties.Settings.Default.Tipps_Anzeigen);
        }  
        private void Button2_Click(object sender, EventArgs e)
        {
            Form.Visible = true;
            Close();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            bool DoThis = true;
            Labels_Clear();
            try
            {
                Form1.zahlint = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                Tutorial_Einstellungen.Play_NoNumber();
                textBox1.Text = "";
                DoThis = false;
                Form1.vonForm1 = false;
                Form1.zahl = true;
                Form1.groß = false;
                Versuch_Abziehen = false;
                Warnung dlg1 = new Warnung();
                dlg1.ShowDialog();
            }
            if (Form1.zahlint > Form1.Bereich && DoThis)
            {
                Tutorial_Einstellungen.Play_NoNumber();
                Form1.vonForm1 = false;
                Form1.zahl = false;
                Form1.groß = true;
                klein = false;
                Versuch_Abziehen = false;
                Warnung dlg1 = new Warnung();
                dlg1.ShowDialog();
            }
            if (Form1.zahlint == 0 && DoThis)
            {
                Tutorial_Einstellungen.Play_NoNumber();
                Form1.vonForm1 = false;
                Form1.zahl = false;
                Form1.groß = false;
                Versuch_Abziehen = false;
                klein = true;
                Warnung dlg1 = new Warnung();
                dlg1.ShowDialog();
            }
            if (Versuch_Abziehen)
            {
                versuche++;
            }
            int versuche2 = Form1.wunschzahl - versuche;
            if (Form1.k < Form1.zahlint)
            {
                label4.Text = "Die gesuchte Zahl ist kleiner!";
                if (versuche2 == 1)
                {
                    label5.Text = "Du hast noch einen Versuch!";
                }
                else
                {
                    label3.Text = "Du hast noch " + versuche2 + " Versuche!";
                }
            }
            if (Form1.k > Form1.zahlint)
            {
                label4.Text = "Die gesuchte Zahl ist größer!";
                if (versuche2 == 1)
                {
                    label5.Text = "Du hast noch einen Versuch!";
                }
                else
                {
                    label3.Text = "Du hast noch " + versuche2 + " Versuche !";
                }
            }
            if (Form1.k == Form1.zahlint)
            {
                Tutorial_Einstellungen.Play_Right();
                button2.Visible = !button2.Visible;
                AcceptButton = button2;
                label6.Text = ("Das ist richtig!");
                HighscoreLesenSchreiben();
                if (versuche2 == 1)
                {
                   label5.Text = "Du hattest noch einen Versuch! ";
                   button2.Text = "Nochmal";
                }
                if (versuche2 == 0)
                {
                  label8.Text = "Du hattest keinen Versuch mehr.";
                }
                if (versuche2 > 1)
                {
                    label3.Text = "Du hattest noch " + versuche2 + " Versuche !";
                    button2.Text = "Nochmal";
                }
            }
            if (versuche2 == 0 && Form1.k != Form1.zahlint)
            {
                Tutorial_Einstellungen.Play_false();
                Labels_Clear();
                label1.Text = "Schade! Du hast alle deine Versuche verbraucht. ";
                label2.Text = "Versuchs am besten gleich noch einmal!";
                label7.Text = "Die richtige Zahl wäre " + Form1.k + " gewesen.";
                button2.Visible = !button2.Visible;
                AcceptButton = button2;
            }
            textBox1.Text = "";
        }
        private void HighscoreLesenSchreiben()
        {
            if (Form1.Bereich == 10)
            {
                if (Properties.Settings.Default.Highscore10 > versuche)
                {
                    Properties.Settings.Default.Highscore10 = versuche;
                }
            }
            if (Form1.Bereich == 25)
            {
                if (Properties.Settings.Default.Highscore25 > versuche)
                {
                    Properties.Settings.Default.Highscore25 = versuche;
                }
            }
            if (Form1.Bereich == 50)
            {
                if (Properties.Settings.Default.Highscore50 > versuche)
                {
                    Properties.Settings.Default.Highscore50 = versuche;
                }
            }
            if (Form1.Bereich == 75)
            {
                if (Properties.Settings.Default.Highscore75 > versuche)
                {
                    Properties.Settings.Default.Highscore75 = versuche;
                }
            }
            if (Form1.Bereich == 100)
            {
                if (Properties.Settings.Default.Highscore100 > versuche)
                {
                    Properties.Settings.Default.Highscore100 = versuche;
                }
            }
            Properties.Settings.Default.Save();
        }
        private void TextBox1_MouseHover(object sender, EventArgs e)
        {
            toolTipZahl.SetToolTip(textBox1, "Gib hier eine Zahl in dem ausgewählten Zahlenbereich ein und schaue, ob die Zahl richtig ist." +Environment.NewLine+
                " Versuche die Zahl mit so wenigen Versuchen wie möglich zu eraten.");
        }
        private void Tipps(bool what)
        {
            toolTipBeenden.Active = what;
            toolTipNochmal.Active = what;
            toolTipZahl.Active = what;
        }
        private void Labels_Clear()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }
    }
}