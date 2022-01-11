using System;
using System.Windows.Forms;

namespace Zahlenraten
{
    public partial class Wilkommen : Form
    {
        public Wilkommen()
        {
            InitializeComponent();
        }
        private void Wilkommen_Load(object sender, EventArgs e)
        {
            BackColor = Properties.Settings.Default.Hintergrundfarbe;
            Tipps(Properties.Settings.Default.Tipps_Anzeigen);
        }
        private void OK_Click(object sender, EventArgs e)
        {
            if (cb_nicht_mehr_anzeigen.Checked)
            {
                Properties.Settings.Default.Wilkommen_Anzeigen = false;
            }
            if (!cb_nicht_mehr_anzeigen.Checked)
            {
                Properties.Settings.Default.Wilkommen_Anzeigen = true;
            }
            Properties.Settings.Default.Save();
            Close();
        }
        private void Tipps(bool what)
        {
            toolTipFenster.Active = what;
            toolTipOK.Active = what;
        }
    }
}