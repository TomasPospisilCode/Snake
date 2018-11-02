using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{

     public enum Směr
    {
        Nahoru,
        Dolů,
        Doleva,
        Doprava
    };

    class Nastavení
    {
        public static int Šířka { get; set; }
        public static int Výška { get; set; }
        public static int Rychlost { get; set; }
        public static int Skóre { get; set; }
        public static int Body { get; set; }
        public static bool KonecHry { get; set; }
        public static Směr směr { get; set; }

        public Nastavení()
        {
            Šířka = 16;
            Výška = 16;
            Rychlost = 16;
            Skóre = 0;
            Body = 100;
            KonecHry = false;
            směr = Směr.Dolů;
        }
    }
}
