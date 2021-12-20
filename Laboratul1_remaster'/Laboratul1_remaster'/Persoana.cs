using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratul1_remaster_
{
    class Persoana
    {
        protected string nume;
        protected byte varsta;

        public Persoana() { }
        public Persoana(string nume, byte varsta)
        {
            this.nume = nume;
            this.varsta = varsta;
        }
    }
}
