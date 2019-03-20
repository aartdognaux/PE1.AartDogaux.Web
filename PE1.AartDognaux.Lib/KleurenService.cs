using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace PE1.AartDognaux.Lib
{
    public class KleurenService
    {
        public static IEnumerable GenereerCssKleuren(int aantalKleuren)
        {
            List<string> zinnen = new List<string>();

            Random random = new Random();
            // Maakt een lijst met alle kleuren
            for (int i = 0; i < aantalKleuren; i++)
            {
                int randomNummer1 = random.Next(0, 256);
                int randomNummer2 = random.Next(0, 256);
                int randomNummer3 = random.Next(0, 256);
                string zinKleur = "rgb(" + randomNummer1 + "," + randomNummer2 + "," + randomNummer3 + ")";
                zinnen.Add(zinKleur);
            }
            // Zet lijst om naar IEnumerable
            IEnumerable<string> ienumK = (IEnumerable<string>)zinnen;
            foreach (string i in ienumK)
            {

                Console.WriteLine(i);
            }
            return ienumK;
        }

        public static IEnumerable GenereerGrijsTinten(int aantalKleuren)
        {
            List<string> zinnen = new List<string>();
            Random random = new Random();
            // Maakt een lijst met alle kleuren
            for (int i = 0; i < aantalKleuren; i++)
            {
                int randomNummer1 = random.Next(0, 256);

                string zinGrijs = "rgb(" + randomNummer1 + "," + randomNummer1 + "," + randomNummer1 + ")";
                zinnen.Add(zinGrijs);
            }
            // Zet lijst om naar IEnumerable
            IEnumerable<string> ienumG = (IEnumerable<string>)zinnen;
            foreach (string i in ienumG)
            {
                Console.WriteLine(i);
            }
            return ienumG;
        }
    }
}
