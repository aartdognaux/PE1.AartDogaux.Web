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
                //zinnen.Add(zinKleur);
                yield return zinKleur;
            }
            // Zet lijst om naar IEnumerable
            //IEnumerable<string> ienumK = (IEnumerable<string>)zinnen;

            //return ienumK;
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
                //zinnen.Add(zinGrijs);
                yield return zinGrijs;
            }
            // Zet lijst om naar IEnumerable
            //IEnumerable<string> ienumG = (IEnumerable<string>)zinnen;

            //return ienumG;
        }

        // nieuwe public IEnumerable maken varianten
        public static IEnumerable GenereerCssKleuren(int aantalKleuren, Variant kleur)
        {
            List<string> zinnen = new List<string>();

            Random random = new Random();
            // Maakt een lijst met alle kleuren
            if (kleur == Variant.Roodachtig)
            {
                for (int i = 0; i < aantalKleuren; i++)
                {
                    int randomNummer1 = random.Next(128, 256);
                    int randomNummer2 = randomNummer1 / 2;
                    int randomNummer3 = randomNummer1 / 2;
                    string zinKleur = "rgb(" + randomNummer1 + "," + randomNummer2 + "," + randomNummer3 + ")";
                    //zinnen.Add(zinKleur);
                    yield return zinKleur;
                }
            }

            if (kleur == Variant.Groenachtig)
            {

                for (int i = 0; i < aantalKleuren; i++)
                {
                    int randomNummer2 = random.Next(128, 256);
                    int randomNummer1 = randomNummer2 / 2;
                    int randomNummer3 = randomNummer2 / 2;
                    string zinKleur = "rgb(" + randomNummer1 + "," + randomNummer2 + "," + randomNummer3 + ")";
                    //zinnen.Add(zinKleur); // ipv zinnen.add Yield gebruiken
                    yield return zinKleur;
                }
            }

            if (kleur == Variant.Blauwachtig)
            {

                for (int i = 0; i < aantalKleuren; i++)
                {
                    int randomNummer3 = random.Next(128, 256);
                    int randomNummer2 = randomNummer3 / 2;
                    int randomNummer1 = randomNummer3 / 2;
                    string zinKleur = "rgb(" + randomNummer1 + "," + randomNummer2 + "," + randomNummer3 + ")";
                    //zinnen.Add(zinKleur);
                    yield return zinKleur;
                }
            }
            //IEnumerable<string> ienumV = (IEnumerable<string>)zinnen;
            //return ienumV;
        }
    }
}
