using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizickaAktivnost.BusinessLogic
{
    public class Grupa : FizickaAktivnost
    {

        public List<FizickaAktivnost> grupa = new List<FizickaAktivnost>();

        public void dodaj(FizickaAktivnost f)
        {
            grupa.Add(f);
        }


        public void ukloni(FizickaAktivnost f)
        {
            grupa.Remove(f);
        }

        public override double brojKalorija()
        {
            double sum = 0;

            foreach (var f in grupa)
            {
                sum += f.brojKalorija();
            }

            return sum;
        }

        public override double trajanje()
        {
            double sum = 0;

            foreach (var f in grupa)
            {
                sum += f.trajanje();
            }

            return sum;
        }

        public override string ToString()
        {
            return $"{grupa.Count}, {trajanje()} min";
        }
    }
}
