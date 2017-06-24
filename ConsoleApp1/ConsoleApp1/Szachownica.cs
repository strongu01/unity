using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja1.Figury
{
    class Szachownica
    {
        private static Szachownica szachow = new Szachownica();

        private string[,] plansza;

        private Szachownica()
        {
            plansza = new string[8, 8];
        }

        static Szachownica() { }

        public static Szachownica Instancja
        {
            get
            {
                return szachow;
            }
        }

        public string this[char x, int y]
        {
            get
            {
                return plansza[x - 65, y];
            }
            set
            {
                plansza[x - 65, y] = value;
            }
        }
    }
}
