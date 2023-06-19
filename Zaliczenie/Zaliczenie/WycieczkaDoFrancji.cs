using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie
{
    internal class WycieczkaDoFrancji : Wycieczka
    {
        public double ilośćOsób;
        public double cenaZaOsobęPole;
        public WycieczkaDoFrancji(double ilośćOsób) : base(50, 50000)
        {
            this.ilośćOsób = ilośćOsób;
            this.cenaZaOsobęPole = base.cenaZaOsobę(ilośćOsób);
        }
        public string toString()
        {
            return "Cena za osobę " + cenaZaOsobęPole + " Ilość osób " + ilośćOsób
                + " Cena całkowita " + całaCena + " Maksymalna ilość osób " + maxOsób;
        }
    }

}
