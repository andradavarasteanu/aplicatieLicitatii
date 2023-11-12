using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_VarasteanuAndrada
{
    internal class Licitatie
    {
        private Obiect obiectLicitat;
        private List<Oferta> oferte;
        private Selectie castigator;

        public Licitatie(Obiect obiect, List<Oferta> oferte, Selectie castigator)
        {
            this.obiectLicitat = obiect;
            this.oferte = new List<Oferta>();
            this.castigator = castigator;
        }

        public Obiect ObiectLicitat { get { return obiectLicitat; }  set { obiectLicitat = value;  } }
        public List<Oferta> Oferte { get { return oferte; } set { oferte = value; } }
        public Selectie Castigator { get { return castigator; } set { castigator = value; } }

        public bool verificaTimp(Oferta o, Obiect obiectLicitat)
        {
            if (o.TimpulPlasarii.Day > obiectLicitat.TimpPlasare.Day)
                return false;
            else return true;
        }
        public static Licitatie operator+(Licitatie l, Oferta of)
        {
            if (l.verificaTimp(of, l.ObiectLicitat) == true)
                l.oferte.Add(of);
            return l;
        }

        
        
    }
}
