using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_VarasteanuAndrada
{
    internal class Candidat:ICloneable

    {   private readonly int id;
        private string nume;
        private string email;
        private string nrTelefon;
        private string adresa;
        private string[] categoriiDeInteres;
       

        public Candidat(int id,string nume, string email, string nrTelefon, string adresa, string[] categoriiDeInteres)
        {
            this.id = id;
            this.nume = nume;
            this.email = email;
            this.nrTelefon = nrTelefon;
            this.adresa = adresa;
            this.categoriiDeInteres=new string[categoriiDeInteres.Length];
            for(int i = 0; i < this.categoriiDeInteres.Length; i++)
            {
                this.categoriiDeInteres[i] = categoriiDeInteres[i];
            }
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public string Email { get { return email; }  set { email = value; } }
        public string NrTelefon { get { return nrTelefon; } set { nrTelefon = value; } }
        public string Adresa { get { return adresa; }  set { adresa = value; } }
        public int Id { get { return id; }  }

        public string this[int index]
        {
            get
            {
                if (categoriiDeInteres != null && index >= 0 && index < categoriiDeInteres.Length)
                    return categoriiDeInteres[index];
                else
                    return "0";
            }
        }


        public object Clone()
        {
            Candidat clona = (Candidat)this.MemberwiseClone();
            string[] categoriiNoi = (string[])categoriiDeInteres.Clone();
            clona.categoriiDeInteres = categoriiNoi;
            return clona;
        }

        public override string ToString()
        {
            string mesajAfisare = "";
            mesajAfisare += " Candidatul " + nume + Environment.NewLine;
            return mesajAfisare;

        }
    }
}
