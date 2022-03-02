using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nelinurk
{
    class Program
    {
        static void Main(string[] args)
        {
            Nelinurkk Kujund = new Nelinurkk();
            Console.WriteLine("Ruut/1, Ristkülik/2, Romb/3, Rööpkülik/4");
            string sym = Console.ReadLine();
            Console.WriteLine("Sisetage nelinurga kõrgus ja laius");
            Kujund.Korgus = double.Parse(Console.ReadLine());
            Kujund.Laius = double.Parse(Console.ReadLine());
            double P = Kujund.Perimetr();
            double pindala = Kujund.Pindala();
            if (sym == "1")
            {
                Console.WriteLine("Väga hästi!");
            }
            else if (sym == "2")
            {


            }
            else if (sym == "3")
            {
          
            }
            else if (sym == "4")
            {

            }
            else
            {
                Console.WriteLine("Vale andmetüüp");
            }
            Console.WriteLine($"Nelinurga ümbermõõt - {P} cm ja pindala - {pindala} cm2");


            Console.ReadLine();
        }
    }
}