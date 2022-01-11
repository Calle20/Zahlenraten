using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zahlenraten
{
    public partial class Warnung : Form
    {
        public Warnung()
        {
            InitializeComponent();
        }
        private readonly int BereichNeu = Form1.Bereich - 1;
        private void OK_Click(object sender, EventArgs e)
        {
            bool richtig = true;
            if (Form1.vonForm1)
            {
                try
                {
                    Form1.wunschzahl = Convert.ToInt32(Versuch.Text);
                }
                catch
                {
                    Tutorial_Einstellungen.Play_NoNumber();
                    ZuGroß.Visible = false;
                    GroßBereich.Visible = false;
                    KeineZahl.Visible = true;
                    richtig = false;
                    toolTipVersuch.SetToolTip(Versuch, "Geben sie hier eine Zahl ein!");
                }
                finally
                {
                    if (Form1.wunschzahl > Form1.Bereich - 1 && richtig == true)
                    {
                        Tutorial_Einstellungen.Play_NoNumber();
                        ZuGroß.Visible = true;
                        KeineZahl.Visible = false;
                        GroßBereich.Visible = false;
                        toolTipVersuch.SetToolTip(Versuch, "Geben sie hier eine Zahl kleiner als " + BereichNeu + " ein!");
                    }
                    else if (Form1.wunschzahl <= Form1.Bereich - 1 && richtig == true)
                    {
                        Close();
                    }
                    Versuch.Text = "";
                    Versuch.Focus();
                }
            }
            if (!Form1.vonForm1)
            {
                try
                {
                    Form1.zahlint = Convert.ToInt32(Versuch.Text);
                }
                catch
                {
                    Tutorial_Einstellungen.Play_NoNumber();
                    Klein.Visible = false;
                    ZuGroß.Visible = false;
                    GroßBereich.Visible = false;
                    KeineZahl.Visible = true;
                    richtig = false;
                    toolTipVersuch.SetToolTip(Versuch, "Gib hier eine Zahl ein!");
                }
                finally
                {
                    if (Form1.zahlint > Form1.Bereich && richtig == true)
                    {
                        Tutorial_Einstellungen.Play_NoNumber();
                        ZuGroß.Visible = false;
                        KeineZahl.Visible = false;
                        GroßBereich.Visible = true;
                        Klein.Visible = false;
                        toolTipVersuch.SetToolTip(Versuch, "Geben sie hier eine Zahl kleiner als " + Form1.Bereich + " ein!");
                    }
                    else if (Form1.zahlint == 0 && richtig == true)
                    {
                        Tutorial_Einstellungen.Play_NoNumber();
                        ZuGroß.Visible = false;
                        KeineZahl.Visible = false;
                        GroßBereich.Visible = false;
                        Klein.Visible = true;
                        toolTipVersuch.SetToolTip(Versuch, "Geben sie hier eine andere Zahl als 0 ein!");
                    }
                    else if (Form1.zahlint <= Form1.Bereich && richtig == true)
                    {
                        Close();
                        Spiel.Versuch_Abziehen = true;
                    }
                    Versuch.Text = "";
                    Versuch.Focus();
                }
            }
        }
        private void Warnung_Load(object sender, EventArgs e)
        {
            Klein.Text = "Achtung! Du hast 0 eingegeben.\nNull liegt nicht im Zahlenbereich\n1 - " + Form1.Bereich + ". Bitte gib eine größere Zahl\nein und drücke auf OK.";
            Tipps(Properties.Settings.Default.Tipps_Anzeigen);
            Versuch.BackColor = Color.Red;
            Versuch.Focus();
            if (Form1.vonForm1)
            {
                if (Form1.groß) 
                {
                    ZuGroß.Visible = true;
                    KeineZahl.Visible = false;
                    GroßBereich.Visible = false;
                    Klein.Visible = false;
                    toolTipVersuch.SetToolTip(Versuch, "Gib hier eine Zahl kleiner als " + BereichNeu + " ein!");
                }
                if (Form1.zahl) 
                {
                    ZuGroß.Visible = false;
                    KeineZahl.Visible = true;
                    GroßBereich.Visible = false;
                    Klein.Visible = false;
                    toolTipVersuch.SetToolTip(Versuch, "Gib hier eine Zahl ein!");
                }
            }
            if (!Form1.vonForm1)
            {
                if (Form1.zahl)
                {
                    ZuGroß.Visible = false;
                    GroßBereich.Visible = false;
                    KeineZahl.Visible = true;
                    Klein.Visible = false;
                    toolTipVersuch.SetToolTip(Versuch, "Gib hier eine Zahl ein!");
                }
                if (Form1.groß)
                {
                    GroßBereich.Visible = true; 
                    ZuGroß.Visible = false;
                    KeineZahl.Visible = false;
                    Klein.Visible = false;
                    toolTipVersuch.SetToolTip(Versuch, "Gib hier eine Zahl kleiner als " + Form1.Bereich + " ein");
                }
                if (Spiel.klein)
                {
                    GroßBereich.Visible = false;
                    ZuGroß.Visible = false;
                    KeineZahl.Visible = false;
                    Klein.Visible = true;
                    toolTipVersuch.SetToolTip(Versuch, "Gib hier eine Zahl größer als 0 ein.");
                }
            } 
        }
        private void Tipps(bool what)
        {
            toolTipVersuch.Active = what;
            toolTipOK.Active = what;
        }
    }
}