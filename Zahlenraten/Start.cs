using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zahlenraten
{
    public enum Buttons
    {
        button2,
        button3,
        button4,
        button5,
        button6,
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int wunschzahl = 0;
        public static int Bereich { get; set; }
        public static int k { get; set; }
        public static bool groß = false;
        public static bool zahl = false;
        public static bool vonForm1 { get; set; }
        public static int zahlint { get; set; }
        public static string File1 { get; set; }
        public static string FilePfad { get; set; }
        public static string temp0 { get; set; }
        public Buttons Buttons{ get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            bool richtig = true;
            try
            {
                wunschzahl = Convert.ToInt32(Versuch.Text);
            }
            catch
            {
                zahl = true;
                richtig = false;
                vonForm1 = true;
                Warnung dlg1 = new Warnung();
                dlg1.ShowDialog();
                Hide();
                Spiel f = new Spiel();
                f.Show();
                f.Form = this;
            }
            if (wunschzahl > Bereich - 1 && richtig == true) 
            {
                groß = true;
                vonForm1 = true;
                Warnung dlg1 = new Warnung();
                dlg1.ShowDialog();
                Hide();
            }
            if (wunschzahl <= Bereich - 1 && richtig == true) 
            {
                Spiel f = new Spiel();
                f.Show();
                f.Form = this;
                Hide();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Buttons = Buttons.button2;
            Bereich = 10;
            button1.Enabled = true;
            FarbeÄndern();
            button2.BackColor = Color.Lime;
            Schreiben(10);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Bereich = 25;
            Buttons = Buttons.button3;
            button1.Enabled = true;
            FarbeÄndern();
            button3.BackColor = Color.Lime;
            Schreiben(25);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Bereich = 50;
            Buttons = Buttons.button4;
            button1.Enabled = true;
            FarbeÄndern();
            button4.BackColor = Color.Lime;
            Schreiben(50);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Bereich = 75;
            Buttons = Buttons.button5;
            button1.Enabled = true;
            FarbeÄndern();
            button5.BackColor = Color.Lime;
            Schreiben(75);
        }
        private void button6_Click(object sender, EventArgs e)
        {Bereich = 100;
            Buttons = Buttons.button6;
            button1.Enabled = true;
            FarbeÄndern();
            button6.BackColor = Color.Lime;
            Schreiben(100);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Focus_Überprüfen();
            BackColor = Properties.Settings.Default.Hintergrundfarbe;
            toolTipStart.SetToolTip(button1, "Wenn alle notwendigen Einstellungen (Versuche, Zahlenbereich)"+Environment.NewLine+
            "vorgenommen wurden, kann hier das Spiel gestartet werden.");
            toolTipVersuche.SetToolTip(Versuch,
            "Hier kanst du, um das Spiel schwieriger zu gestalten, eine Anzahl an Versuchen eingeben." + Environment.NewLine +
            "Falls du zum Raten mehr als deine ausgewählte Anzahl an Versuchen benötigst, ist das  " + Environment.NewLine +
            "Spiel verloren. Wenn du einen Zahlenbereich ausgewählt hast, wird automatisch die    " + Environment.NewLine +
            "maxmimale Anzahl an Versuchen für diesen Zahlenbereich eingestellt. Diese kannst du ändern.");
            Tipps(Properties.Settings.Default.Tipps_Anzeigen);
            Tutorial_Einstellungen.Willkommen_Überprüfen();
        }
        private void Einstellungen_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            Einstellungen f = new Einstellungen();
            f.ShowDialog();
            Tipps(Properties.Settings.Default.Tipps_Anzeigen);
            BackColor = Properties.Settings.Default.Hintergrundfarbe;
            pictureBox1.Visible = false;
            if (Einstellungen.IsClose)
            {
                Application.Exit();
            }
            Versuch.Focus();
        }
        private void Highscore_Click(object sender, EventArgs e)
        {
            Highscore f = new Highscore();
            f.ShowDialog();
            Versuch.Focus();
        }
        public void FarbeÄndern()
        {
            button2.BackColor = SystemColors.Control;
            button2.UseVisualStyleBackColor = true;
            button3.BackColor = SystemColors.Control;
            button3.UseVisualStyleBackColor = true;
            button4.BackColor = SystemColors.Control;
            button4.UseVisualStyleBackColor = true;
            button5.BackColor = SystemColors.Control;
            button5.UseVisualStyleBackColor = true;
            button6.BackColor = SystemColors.Control;
            button6.UseVisualStyleBackColor = true;
        }
        public void Tipps(bool what)
        {
            toolTipVersuche.Active = what;
            toolTipEinstellungen.Active = what;
            toolTipHighscore.Active = what;
            toolTipStart.Active = what;
            toolTipZahlenbereichAuswählen.Active = what;
        }
        private void RadioButtonLeicht_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLeicht.Checked)
            {
                temp0 = Versuch.Text;
                int temp = Bereich - 1;
                if (Bereich == 0)
                {
                    Versuch.Text = "";
                }
                if (Bereich > 0)
                {
                    Versuch.Text = temp.ToString();
                }
                Versuch.Enabled = false;
                Tutorial_Einstellungen.Ändern(true);
                Schreiben(Bereich);
            }
            if (radioButtonSchwer.Checked)
            {
                Versuch.Text = "";
                Versuch.Text = temp0;
                Versuch.Enabled = true;
                Versuch.Focus();
                Versuch.SelectionStart = Versuch.Text.Length;
                Versuch.SelectionLength = 0;
                Tutorial_Einstellungen.Ändern(false);
            }
        }
        private void Focus_Überprüfen()
        {
            bool temp = Properties.Settings.Default.Leicht;
            if (temp)
            {
                Versuch.Enabled = false;
                radioButtonLeicht.Checked = true;
            }
            if (!temp)
            {
                Versuch.Focus();
                Versuch.Enabled = true;
                radioButtonSchwer.Checked = true;
            }
        }
        private void Schreiben(int Zahl)
        {
            int ZahlTemp = Zahl - 1;
            bool temp = Properties.Settings.Default.Leicht;
            if (temp)
            {
                Versuch.Text = ZahlTemp.ToString();
            }
            if (!temp)
            {
                
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Control control = GetChildAtPoint(e.Location);
            if (control != null)
            {
                if (!toolTipVersuche.ShowAlways)
                {
                    string toolTipString = toolTipVersuche.GetToolTip(control);
                    toolTipVersuche.ShowAlways = true;
                    toolTipVersuche.Show(toolTipString, control, control.Width / 2, control.Height / 2);
                }
            }
            else
            {
                toolTipVersuche.ShowAlways = false;
            }
            if (control != null)
            {
                if (!toolTipStart.ShowAlways)
                {
                    string toolTipString = toolTipStart.GetToolTip(control);
                    toolTipStart.ShowAlways = true;
                    toolTipStart.Show(toolTipString, control, control.Width / 2, control.Height / 2);
                }
            }
            else
            {
                toolTipStart.ShowAlways = false;
            }
        }
        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            if(!Visible)
            {
                Randomnizer(Bereich);
            }
        }
        private void Randomnizer(int maxValue)
        {
            var r = new Random();
            k = r.Next(1, maxValue);
            Bereich = maxValue;
        }
    }
}