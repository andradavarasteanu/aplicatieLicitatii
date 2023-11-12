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
    public partial class ListaCandidatiForm : Form
    {
        string connString;
        public ListaCandidatiForm()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=candidatiLicitatie.accdb";

        }

        private void btnPreluareDate_Click(object sender, EventArgs e)
        {
            lvCandidati.Items.Clear();

            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand("SELECT * FROM canditatiLicitatie", conexiune);
                OleDbDataReader reader=comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm=new ListViewItem(reader["ID"].ToString());
                    itm.SubItems.Add(reader["nume"].ToString());
                    itm.SubItems.Add(reader["email"].ToString());
                    itm.SubItems.Add(reader["nrTelefon"].ToString());
                    itm.SubItems.Add(reader["adresa"].ToString());
                    List<string> categoriiDeInteres = new List<string>();
                    string categorie = "";
                    for(int i = 1; i <= 3; i++)
                    {
                         categorie = reader["categorie" + i.ToString()].ToString();
                        if (!string.IsNullOrEmpty(categorie))
                        {
                            categoriiDeInteres.Add(categorie);
                        }
                    }
                    string joinedCategories = string.Join(", ", categoriiDeInteres);
                    itm.SubItems.Add(joinedCategories);
                    lvCandidati.Items.Add(itm);


                }
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
            }
            
        }

        private void btnInserare_Click(object sender, EventArgs e)
        {

        }
    }
}
