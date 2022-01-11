using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Drawing;
using System.Collections;
using System.Media;
using System.Windows.Media;
using System.Reflection;

namespace Zahlenraten
{
    class Tutorial_Einstellungen
    {
        public static MediaPlayer Mp { get; set; }
        public static MediaPlayer Mp1 { get; set; }
        public static MediaPlayer Mp2 { get; set; }
        public static void AllesZurücksetzen()
        {
            Properties.Settings.Default.Reset();
        }
        public static void Willkommen_Überprüfen()
        {
            bool Willkommen = Properties.Settings.Default.Wilkommen_Anzeigen;
            if (Willkommen)
            {
                Wilkommen_Zeigen();
            }
            if (!Willkommen)
            {

            }
        }
        public static void Wilkommen_Zeigen()
        {
            Wilkommen f = new Wilkommen();
            f.ShowDialog();
        }
        public static void Ändern(bool Boolen)
        {
            Properties.Settings.Default.Leicht = Boolen;
            Properties.Settings.Default.Save();
        }
        public static void Play_Right()
        {
            if (Properties.Settings.Default.PlayRight)
            {
                SoundPlayer sp=new SoundPlayer(Properties.Resources.WIN_sound_effect);
                sp.Play();
            }
        }
        public static void Play_NoNumber()
        {
            if (Properties.Settings.Default.PlayIncorect)
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.incorrect_sound_effect);
                sp.Play();
            }
        }
        public static void Play_false()
        {
            if (Properties.Settings.Default.PlayWrong)
            {
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Wrong_Answer_Sound_Effect);
                sp.Play();
            }
        }
    }
}