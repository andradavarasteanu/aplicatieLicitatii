using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_VarasteanuAndrada
{
    internal class Oferta:IComparable
    {
        private Candidat candidat;
        private Obiect obiect;
        private float pretOferit;
        private DateTime timpulPlasarii;

        public Oferta(Candidat candidat, Obiect obiect, float pretOferit, DateTime timpulPlasarii)
        {
            this.candidat = candidat;
            this.obiect = obiect;
            this.pretOferit = pretOferit;
            this.timpulPlasarii = timpulPlasarii;
        }

        public Candidat Candidat { get { return candidat; }  set { candidat = value; } }
        public Obiect Obiect { get { return obiect; } set { obiect = value; } }
        public float PretOferit { get { return pretOferit; } set { pretOferit = value; } }
        public DateTime TimpulPlasarii { get { return timpulPlasarii; } set { timpulPlasarii = value; } }

        public int CompareTo(object obj)
        {
            Oferta o = (Oferta)obj;
            if (o == null)
            {
                return 0;
            }
            return this.PretOferit.CompareTo(o.pretOferit);
        }

        public override string ToString()
        {
            string mesaj = "";
            mesaj += " Oferta a fost plasata de candidatul " + candidat.ToString() + " pentru obiectul " + obiect.ToString();
            mesaj += ". Pretul oferit este de " + pretOferit + Environment.NewLine;
            return mesaj;
        }


    }
}
