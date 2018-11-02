using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    class Vstup
    {
        //Načte seznam dostupných tlačítek na klávesnici
        private static Hashtable tabulkaKlaves = new Hashtable();

        //Provede kontrolu, zda je stisklá určitá klávesa
        public static bool StisknutaKlavesa(Keys klavesa)
        {
            if (tabulkaKlaves[klavesa] == null)
            {
                return false;
            }

            return (bool)tabulkaKlaves[klavesa];
        }

        //Zjistí, zda je stisklá klávesa
        public static void ZměnaStavu(Keys klavesa, bool stav)
        {
            tabulkaKlaves[klavesa] = stav;
        }
    }
}
