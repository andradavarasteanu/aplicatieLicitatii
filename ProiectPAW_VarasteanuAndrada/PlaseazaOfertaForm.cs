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
    public partial class PlaseazaOfertaForm : Form
    { private Obiect obiect;

        public Obiect obiectPlasat { get; private set; }
        public PlaseazaOfertaForm(Obiect obiect)
        {
            InitializeComponent();
            this.obiect = obiect;
        }

        private void btnPlaseaza_Click(object sender, EventArgs e)
        {
            string candidatOf = tbNumeCandidat.Text;
            float sumaoferita = float.Parse(tbSumaOferita.Text);
            obiect.Loturi.Add(sumaoferita);
            obiectPlasat = obiect;
            DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
