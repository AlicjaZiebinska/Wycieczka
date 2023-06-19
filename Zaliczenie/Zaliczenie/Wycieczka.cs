using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie
{
    internal class Wycieczka
    {
        public Wycieczka(double maksymalnaIlośćOsób, double cena)
        {
            maxOsób = maksymalnaIlośćOsób;
            całaCena = cena;
        }
       
        public double całaCena;
        public double maxOsób;

        public double cenaZaOsobę(double ilośćOsób)
        {
            
            if (ilośćOsób <= maxOsób) 
            {
                double ileZaJednąOsobę = całaCena / ilośćOsób;
                return Math.Round(ileZaJednąOsobę, 2, MidpointRounding.ToEven);
            }
            else
            {
                return 0;
            }
        }
    }
}
