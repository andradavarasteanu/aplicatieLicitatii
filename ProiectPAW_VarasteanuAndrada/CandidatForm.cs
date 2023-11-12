using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProiectPAW_VarasteanuAndrada
{
    public partial class CandidatForm : Form
    {
        public CandidatForm()
        {
            InitializeComponent();
        }

        private void btnListaCandidati_Click(object sender, EventArgs e)
        {
            Hide();
            ListaCandidatiForm listaCandidatiForm = new ListaCandidatiForm();
            listaCandidatiForm.ShowDialog();
        }

        private void btnAdaugaCandidat_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=candidatiLicitatie.accdb");

            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection=conexiune;

                comanda.CommandText = "SELECT MAX(ID) FROM canditatiLicitatie";
                int id = Convert.ToInt32(comanda.ExecuteScalar());
                comanda.CommandText = "INSERT INTO canditatiLicitatie VALUES(?,?,?,?,?,?,?,?)";
                comanda.Parameters.Add("ID", OleDbType.Integer).Value = id + 50;
                comanda.Parameters.Add("nume", OleDbType.Char, 50).Value = tbNume.Text;
                comanda.Parameters.Add("email", OleDbType.Char, 30).Value = tbEmail.Text;
                comanda.Parameters.Add("nrTelefon", OleDbType.Char, 11).Value = tbNrTel.Text;
                comanda.Parameters.Add("adresa", OleDbType.Char, 50).Value = tbAdresa.Text;

                string categoriiString = tbCategorii.Text;
                string[] categoriiDeInteres = categoriiString.Split(',');

                comanda.Parameters.AddWithValue("@categorie1", categoriiDeInteres.Length > 0 ? categoriiDeInteres[0].Trim() : string.Empty);
                comanda.Parameters.AddWithValue("@categorie2", categoriiDeInteres.Length > 1 ? categoriiDeInteres[1].Trim() : string.Empty);
                comanda.Parameters.AddWithValue("@categorie3", categoriiDeInteres.Length > 2 ? categoriiDeInteres[2].Trim() : string.Empty);
                comanda.ExecuteNonQuery();

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                tbNume.Clear();
                tbEmail.Clear();
                tbNrTel.Clear();
                tbAdresa.Clear();
                tbCategorii.Clear();
            }

        }
    }
}
