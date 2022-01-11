using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Deployment;
using System.Diagnostics;

namespace Zahlenraten
{
    public partial class Einstellungen : Form
    {
        public Einstellungen()
        {
            InitializeComponent();
        }
        public static bool IsClose = false;
        public static TabPage actualtp { get; set; }
        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Alles_Zurücksetzen_Click(object sender, EventArgs e)
        {
            Tutorial_Einstellungen.AllesZurücksetzen();
            IsClose = true;
            Application.Restart();
        }
        private void TippsWiedAnzeigen_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Tipps_Anzeigen)
            {
                Properties.Settings.Default.Tipps_Anzeigen = false;
                TippsWiedAnzeig.Text = "Tipps aktivieren";
                Tipps(false);
            }
            else if (!Properties.Settings.Default.Tipps_Anzeigen)
            {
                Properties.Settings.Default.Tipps_Anzeigen = true;
                TippsWiedAnzeig.Text = "Tipps deaktivieren";
                Tipps(true);
            }
            Properties.Settings.Default.Save();
        }
        private void Einstellungen_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Tipps_Anzeigen)
            {
                TippsWiedAnzeig.Text = "Tipps deaktivieren";
                Tipps(true);

            }
            if (!Properties.Settings.Default.Tipps_Anzeigen)
            {
                TippsWiedAnzeig.Text = "Tipps aktivieren";
                Tipps(false);
            }
            if (Properties.Settings.Default.PlayRight != cbRightSound.Checked)
            {
                cbRightSound.Checked = false;
            }
            if (Properties.Settings.Default.PlayIncorect != cbIncorrectSound.Checked)
            {
                cbIncorrectSound.Checked = false;
            }
            if (Properties.Settings.Default.PlayWrong != cbWrongSound.Checked)
            {
                cbWrongSound.Checked = false;
            }
        }
        private void Tipps(bool what)
        {
            toolTipAllesReseten.Active = what;
            toolTipHintFarbÄnd.Active = what;
            toolTipOK.Active = what;
            toolTipTippsAnzeig.Active = what;
        }
        private void colorDialog_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Wählen sie die Hintergrundfarbe für das Spiel aus.");
        }
        private void cbRightSound_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRightSound.Checked)
            {
                Properties.Settings.Default.PlayRight = true;
                Tutorial_Einstellungen.Play_Right();
            }
            else
            {
                Properties.Settings.Default.PlayRight = false;
            }
            Properties.Settings.Default.Save();
        }

        private void cbIncorrectSound_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIncorrectSound.Checked)
            {
                Properties.Settings.Default.PlayIncorect = true;
                Tutorial_Einstellungen.Play_NoNumber();
            }
            else
            {
                Properties.Settings.Default.PlayIncorect = false;
            }
            Properties.Settings.Default.Save();
        }

        private void cbWrongSound_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWrongSound.Checked)
            {
                Properties.Settings.Default.PlayWrong = true;
                Tutorial_Einstellungen.Play_false();
            }
            else
            {
                Properties.Settings.Default.PlayWrong = false;
            }
            Properties.Settings.Default.Save();
        }

        private void tabPageBackround_Enter(object sender, EventArgs e)
        {
            colorDialog.CustomColors = Properties.Settings.Default.CustomColors;
            colorDialog.Color = /*Color.Turquoise;*/Properties.Settings.Default.Hintergrundfarbe;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.CustomColors = colorDialog.CustomColors;
                Properties.Settings.Default.Hintergrundfarbe = colorDialog.Color;
                Properties.Settings.Default.Save();
            }
            tabC_Settings.SelectedTab = actualtp;
        }

        private void tabPageSounds_Enter(object sender, EventArgs e)
        {
            actualtp = tabPageSounds;
        }

        private void tabPageGeneral_Enter(object sender, EventArgs e)
        {
            actualtp = tabPageGeneral;
        }
    }
}
