namespace ProiectPAW_VarasteanuAndrada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnVeziProd_Click(object sender, EventArgs e)
        {
            Hide();
            ObiecteLicitatie obiecteMenu = new ObiecteLicitatie();
            obiecteMenu.ShowDialog();
            Close();
        }
    }
}