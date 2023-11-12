using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_VarasteanuAndrada
{
    public  class Obiect:ICalculeazaLoturi
    {
        private string numeObiect;
        private string descriere;
        private float pretDePornire;
        private List<float> ofertePlasate;
        private bool esteVandut;
        private DateTime timpPlasare;
        public Obiect(string numeObiect, string descriere, float pretDePornire, List<float> loturi, bool esteVandut, DateTime timpPlasare)
        {
            this.numeObiect = numeObiect;
            this.descriere = descriere;
            this.pretDePornire = pretDePornire;
            this.ofertePlasate = new List<float>();
            this.esteVandut = esteVandut;
            this.timpPlasare = timpPlasare;
        }

        public string NumeObiect { get { return numeObiect; } set { numeObiect = value; } }
        public string Descriere { get { return descriere; } set { descriere = value; } }
        public float PretDePornire { get { return pretDePornire; } set { pretDePornire=value; } }
        public List<float> Loturi { get { return ofertePlasate; } set { ofertePlasate = value; } }
        public bool EsteVandut { get { return esteVandut; } set { esteVandut = value; } }
      
        public DateTime TimpPlasare { get { return timpPlasare; } set { timpPlasare = value; } }


        public static Obiect operator+(Obiect ob, float oferta)
        {
            ob.ofertePlasate.Add(oferta);
            return ob;
        }
        public override string ToString()
        {
            string mesajAfisare = "";
            mesajAfisare += numeObiect + descriere + " are pretul de pornire : " + pretDePornire + " si pentru acesta s-au plasat urmatoarele oferte: ";
            foreach(float of in ofertePlasate)
            {
                mesajAfisare += of + " ";
            }

            mesajAfisare += ". Este vandut: " + esteVandut;
            return mesajAfisare;
        }

        public float CalculeazaLoturi()
        {
            if (ofertePlasate != null)
            {
                return ofertePlasate.Count;
            }
            else return -1;
        }
    }
}
