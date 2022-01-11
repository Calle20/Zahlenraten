using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zahlenraten
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
            string eingabe;
            string eingabe2;
            eingabe2 = Console.ReadLine();
            int versuche = 0;
            int wunschzahl = Convert.ToInt32(eingabe2);
            Console.WriteLine("Ich denke mir eine Zahl zwischen 0 und 10. Welche ist es?");
            var r = new Random();
            int k = r.Next(1, 10);
            Boolean richtig = false;

            do
            {
                eingabe = Console.ReadLine();
                versuche = versuche + 1;
                int zahl = Convert.ToInt32(eingabe);
                int versuche2 = wunschzahl - versuche;
                if (k < zahl)
                {
                    Console.WriteLine("Die gesuchte Zahl ist kleiner");
                    if (versuche2 == 1)
                    {
                        Console.WriteLine("Du hast noch einen Versuch! ");
                    }
                    else
                    {
                        Console.WriteLine("Du hast noch " + versuche2 + " Versuche");
                    }
                }

                if (k > zahl)
                {
                    Console.WriteLine("Die gesuchte Zahl ist größer!");
                    if (versuche2 == 1)
                    {
                        Console.WriteLine("Du hast noch einen Versuch! ");
                    }
                    else
                    {
                        Console.WriteLine("Du hast noch " + versuche2 + " Versuche !");
                    }
                }

                if (k == zahl)
                {
                    Console.WriteLine("Das ist richtig!");
                    if (versuche2 == 1)
                    {
                        Console.WriteLine("Du hattest noch einen Versuch! ");
                    }
                    else
                    {
                        Console.WriteLine("Du hattest noch " + versuche2 + " Versuche !");
                    }

                    richtig = true;

                }
                if (versuche2 == 0)
                {
                    Console.WriteLine("Schade! Du hast alle deine Versuche vebraucht. Versuchs am besten gleich noch einmal");
                    break;
                }
            } while (!richtig);
        }
    }
}
