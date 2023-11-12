using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_VarasteanuAndrada
{
    public partial class AdaugaProd : Form
    {
        public AdaugaProd()
        {
            InitializeComponent();
        }

        private void btnAdaugaObLaLic_Click(object sender, EventArgs e)
        {  
            string numeObiect = tbNumeObiect.Text;
            string descriere = tbDescriere.Text;
            float pretDePornire = float.Parse(tbPretPornire.Text);
            bool esteVandut = rbDA.Checked ? true : false;
            DateTime timpPlasare = dateTimePicker1.Value;

            Obiect obiect = new Obiect(numeObiect, descriere, pretDePornire, new List<float>(), esteVandut, timpPlasare);
            ObiecteLicitatie formularObiecte = (ObiecteLicitatie)Application.OpenForms["ObiecteLicitatie"];

            formularObiecte.AdaugaObiectListView(obiect);


            this.Close();
        }
    }
}
