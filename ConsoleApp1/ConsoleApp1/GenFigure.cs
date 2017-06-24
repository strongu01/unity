using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja1.Figury
{
    enum TypFigury
    {
        Goniec,
        Hetman,
        Pionek,
        Wieza
    };

    class GenFigure
    {
        public static Figura GenerujFigure(TypFigury t, Pozycja p, string kolor)
        {
            switch (t)
            {
                case TypFigury.Goniec:
                    {
                        return new Goniec(p, kolor);
                    }
                case TypFigury.Hetman:
                    {
                        return new Hetman(p, kolor);
                    }
                case TypFigury.Pionek:
                    {
                        return new Pionek(p, kolor);
                    }
                case TypFigury.Wieza:
                    {
                        return new Wieza(p, kolor);
                    }
                default:
                    {
                        throw new ArgumentException("Nie ma takiego typu figury");
                    }
            }
        }
    }
}