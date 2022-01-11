using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace Zahlenraten
{
    public partial class Highscore : Form
    {
        public Highscore()
        {
            InitializeComponent();
        }
        private void Highscore_Load(object sender, EventArgs e)
        {
            DateienErstellenÜberprüfen();
            Tipps(Properties.Settings.Default.Tipps_Anzeigen);
        }
        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void DateienErstellenÜberprüfen()
        {
            if (Properties.Settings.Default.Highscore10 < 11) 
            {
                label1.Text = Properties.Settings.Default.Highscore10 + " Versuche";
            }
            else
            {
                label1.Text = "nicht gespielt";
            }
            if(Properties.Settings.Default.Highscore25 < 26)
            {
                label11.Text = Properties.Settings.Default.Highscore25 + " Versuche";
            }
            else
            {
                label11.Text = "nicht gespielt"; 
            }
            if (Properties.Settings.Default.Highscore50 < 52)
            {
                label2.Text = Properties.Settings.Default.Highscore50 + " Versuche";
            }
            else
            {
                label2.Text = "nicht gespielt";
            }
            if (Properties.Settings.Default.Highscore75 < 76)
            {
                label4.Text = Properties.Settings.Default.Highscore75 + " Versuche";
            }
            else
            {  
                label4.Text = "nicht gespielt";
                
            }
            if (Properties.Settings.Default.Highscore100 < 101) 
            {
                label6.Text = Properties.Settings.Default.Highscore100 + " Versuche";
            }
            else
            {
                label6.Text = "nicht gespielt";
            }
        }
        private void Zurücksetzen1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Highscore10 = 12;
            label1.Text = "nicht gespielt";
            Properties.Settings.Default.Save();
        }
        private void Zurücksetzen2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Highscore25 = 27;
            label11.Text = "nicht gespielt";
            Properties.Settings.Default.Save();
        }
        private void Zurücksetzen3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Highscore50 = 53;
            label2.Text = "nicht gespielt";
            Properties.Settings.Default.Save();
        }
        private void Zurücksetzen4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Highscore75 = 77;
            label4.Text = "nicht gespielt";
            Properties.Settings.Default.Save();
        }
        private void Zurücksetzen5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Highscore100 = 102;
            label6.Text = "nicht gespielt";
            Properties.Settings.Default.Save();
        }
        private void Tipps(bool what)
        {
            toolTipOK.Active = what;
            toolTipZurücksetzen.Active = what;
        }
    }
}