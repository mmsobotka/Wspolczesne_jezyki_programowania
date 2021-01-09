using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Element
    {
        public string liczbaAtomowa;
        public string masaAtomowa;
        public string wartosciowosc;
        public string symbolPierwiastka;
        public string nazwaPierwiastka;

        public Element(string liczbaAtomowa, string masaAtomowa, string wartosciowosc, string symbolPierwiastka, string nazwaPierwiastka) 
        {
            this.liczbaAtomowa = liczbaAtomowa;
            this.masaAtomowa = masaAtomowa;
            this.wartosciowosc = wartosciowosc;
            this.symbolPierwiastka = symbolPierwiastka;
            this.nazwaPierwiastka = nazwaPierwiastka;

        }
    }
}
