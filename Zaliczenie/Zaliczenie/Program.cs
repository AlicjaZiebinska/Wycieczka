using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wycieczka Wycieczka1 = new Wycieczka(4, 28000);
            Console.WriteLine(Wycieczka1.cenaZaOsobę(3));
            Wycieczka Wycieczka2 = new Wycieczka(2, 28000);
            Console.WriteLine(Wycieczka2.cenaZaOsobę(3));
            WycieczkaDoFrancji francja = new WycieczkaDoFrancji(48);
            Console.WriteLine(francja.toString());
            Console.ReadLine();
        }
    }
}
