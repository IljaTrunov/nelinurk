using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nelinurk
{
    public class Nelinurkk
    {
        double korgus, laius;
        Tuup tuup;

        public Nelinurkk() { }
        public Nelinurkk(double Korgus, double Laius, Tuup tuup)
        {
            korgus = Korgus;
            laius = Laius;
            this.tuup = tuup;
        }
        public double Korgus
        {
            set { korgus = value; }
            get { return korgus; }
        }
        public double Laius
        {
            set { laius = value; }
            get { return laius; }
        }
        public Tuup Tuup
        {
            get { return tuup; }
        }
        public double Pindala()
        {
            double pindala = korgus * laius;
            return pindala;
        }
        public double Perimetr()
        {
            double P = korgus * 2 + laius * 2;
            return P;
        }
    }
}
