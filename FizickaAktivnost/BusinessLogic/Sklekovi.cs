using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizickaAktivnost.BusinessLogic
{
    public class Sklekovi : FizickaAktivnost
    {
        public int serije, ponavljanja, pauza;

        public Sklekovi(int s, int p, int _pauza, int kilo)
        {
            serije = s;
            ponavljanja = p;
            pauza = _pauza;
            base.kilogrami = kilo;
        }

        public override double brojKalorija()
        {
            return 0.025 * ponavljanja * serije * base.kilogrami;
        }

        public override double trajanje()
        {
            return 2 * ponavljanja * serije + (pauza * serije);
        }

        public override string ToString()
        {
            return $"{serije * ponavljanja}, {trajanje()}";
        }
    }
}
