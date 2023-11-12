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
    public partial class ObiecteLicitatie : Form
    {
        public ObiecteLicitatie()
        {
            InitializeComponent();
            
          
        }

        public void AdaugaObiectListView(Obiect obiect)
        {
            ListViewItem itm = new ListViewItem(obiect.NumeObiect);
            itm.SubItems.Add(obiect.Descriere);
            itm.SubItems.Add(obiect.PretDePornire.ToString());
            itm.SubItems.Add(obiect.EsteVandut ? "Da" : "Nu");
            string oferteplasate = string.Join(",", obiect.Loturi);

            itm.SubItems.Add(oferteplasate);
            itm.SubItems.Add(obiect.TimpPlasare.ToString());
            itm.Tag = obiect;
            listView1.Items.Add(itm);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdaugaProd_Click(object sender, EventArgs e)
        {
            AdaugaProd adaugaProdMenu = new AdaugaProd();
            adaugaProdMenu.ShowDialog();
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            Hide();
            CandidatForm formularCandidat = new CandidatForm();
            formularCandidat.ShowDialog();

        }

        private void salveazaTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
               foreach(ListViewItem itm  in listView1.Items)
                {
                    Obiect ob = (Obiect)itm.Tag;
                    sw.WriteLine(ob.ToString());
                }
                sw.Close();
                listView1.Items.Clear();

            }
        }

        private void btnOferta_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Obiect obiectSelectat = (Obiect)listView1.SelectedItems[0].Tag;
                PlaseazaOfertaForm plaseazaOfertaForm = new PlaseazaOfertaForm(obiectSelectat);
                if (plaseazaOfertaForm.ShowDialog() == DialogResult.OK)
                {
                    obiectSelectat = plaseazaOfertaForm.obiectPlasat;
                    AdaugaObiectListView(obiectSelectat);
                }

            }
        }
    }
}
