using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_VarasteanuAndrada
{
    internal class Selectie
    {
        private Oferta ofertaCastigatoare;
        public Selectie(Oferta ofertaCastigatoare)
        {
            this.ofertaCastigatoare = ofertaCastigatoare;
        }

        public Oferta OfertaCastigatoare { get { return ofertaCastigatoare; } set { ofertaCastigatoare = value; } }


    }
}
