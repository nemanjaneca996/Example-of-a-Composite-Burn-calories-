using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizickaAktivnost.BusinessLogic
{
    public abstract class FizickaAktivnost
    {
        public int kilogrami;

        public abstract double brojKalorija();
        public abstract double trajanje();
    }
}
