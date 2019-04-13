using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizickaAktivnost.BusinessLogic
{
    public class Osoba
    {
        public string ime, prezime;
        public int kilogrami;

        public Osoba()
        {
            
        }

        public Osoba(string Ime, string Prezime, int Kilogrami)
        {
            ime = Ime;
            prezime = Prezime;
            kilogrami = Kilogrami;
        }
    }
}
