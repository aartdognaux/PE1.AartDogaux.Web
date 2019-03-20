using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace PE1.AartDognaux.Lib
{
    public class KleurenService
    {
        public void GenereerCssKleuren(int aantalKleuren)
        {
            IEnumerable<string> kleuren = Enumerable.Empty<string>();
            Random random = new Random();
            for (int i = 0; i < aantalKleuren; i++)
            {
                int randomNummer1 = random.Next(0, 256);
                int randomNummer2 = random.Next(0, 256);
                int randomNummer3 = random.Next(0, 256);
                string zinKleur = "rgb(" + randomNummer1 + "," + randomNummer2 + "," + randomNummer3 + ")";
                
            }
        }

        public void GenereerGrijsTinten(int aantalKleuren)
        {
            Random random = new Random();
            for (int i = 0; i < aantalKleuren; i++)
            {
                int randomNummer1 = random.Next(0, 256);

                string zinGrijs = "rgb(" + randomNummer1 + "," + randomNummer1 + "," + randomNummer1 + ")";

            }
        }
    }

    public enum KleurVariant
    {
        Roodachtig,
        Groenachtig,
        Blauwachtig
    }
}
