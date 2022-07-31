using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Schrauben
{
    class Program
    {

        [STAThread]
        static void Main()
        {

            new GUI_control();

        }

    }

    public class CatiaControl
    {
        public CatiaControl(Schraube schraube)
        {
            try
            {

                CatiaConnection cc = new CatiaConnection();

                // Finde Catia Prozess
                if (cc.CATIALaeuft())
                {
                    Console.WriteLine("0");

                    // Öffne ein neues Part
                    cc.ErzeugePart();
                    Console.WriteLine("1");

                    // Erstelle eine Skizze
                    cc.ErstelleLeereSkizze();
                    Console.WriteLine("2");

                    //Produkt dasProdukt = new Produkt(schraube.Wunschgewindelaenge,) ;     //Was für Daten will er hier in der Klammer haben????

                    cc.ErzeugeZylinder(schraube);
                    Console.WriteLine("Schaft");
                                       

                    cc.ErzeugeGewindeHelix(schraube);
                    Console.WriteLine("Gewinde");

                    cc.Senkkopf(schraube);
                    Console.WriteLine("Senkkopf");
                    /*
                    if (dasProdukt.Wunschschraubenkopf == "Zylinderkopf")       
                    {
                        cc.Zylinderkopf(dasProdukt);
                        Console.WriteLine("Zylinderkopf");

                        cc.InnensechskantZ(dasProdukt);
                        Console.WriteLine("Innensechskant");
                    }

                    else if (dasProdukt.Wunschschraubenkopf == "Sechskant")
                    {
                        cc.Sechskant(dasProdukt);
                        Console.WriteLine("Sechskant");
                    }
                    
                    else if (dasProdukt.Wunschschraubenkopf == "Senkkopf")
                    {
                        cc.Senkkopf(dasProdukt);
                        Console.WriteLine("Senkkopf");

                        cc.InnensechskantS(dasProdukt);
                        Console.WriteLine("Innensechskant");
                    }

                    else if (dasProdukt.Wunschschraubenkopf == "Gewindestift")
                    {
                        cc.Gewindestift(dasProdukt);
                        Console.WriteLine("Gewindestift");

                        cc.InnensechskantGS(dasProdukt);
                        Console.WriteLine("Innensechskant");
                    }
                                       
                    

                    //Wann und wo den Schlitz anbinden
                    cc.Schlitz();
                    Console.WriteLine("Schlitz");
                    */
                }
                else
                {
                    Console.WriteLine("Laufende Catia Application nicht gefunden");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception aufgetreten");
            }
            Console.WriteLine("Fertig - Taste drücken.");
            Console.ReadKey();

        }
        /*
        static void Main(string[] args)
        {
            new CatiaControl();
        }
        */
    }

}

