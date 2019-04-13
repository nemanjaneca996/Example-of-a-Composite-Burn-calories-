using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizickaAktivnost.BusinessLogic
{
    public class Trcanje : FizickaAktivnost
    {
        public int Trajanje { get; set; }
        public int Brzina { get; set; }

        public Trcanje(int t, int b, int kilo)
        {
            Trajanje = t;
            Brzina = b;
            base.kilogrami = kilo;
        }


        public override double brojKalorija()
        {
            return 0.7 * Trajanje * Brzina / 60 * base.kilogrami;
        }

        public override double trajanje()
        {
            return Trajanje;
        }

        public override string ToString()
        {
            return $"{Trajanje * Brzina}, {Trajanje}min";
        }
    }
}
