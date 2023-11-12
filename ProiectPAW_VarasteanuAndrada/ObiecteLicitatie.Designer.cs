namespace ProiectPAW_VarasteanuAndrada
{
    partial class ObiecteLicitatie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nume = new System.Windows.Forms.ColumnHeader();
            this.Descriere = new System.Windows.Forms.ColumnHeader();
            this.PretPornire = new System.Windows.Forms.ColumnHeader();
            this.Disponibil = new System.Windows.Forms.ColumnHeader();
            this.nrOfertePlasate = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salveazaTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOferta = new System.Windows.Forms.Button();
            this.btnAdaugaProd = new System.Windows.Forms.Button();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Descriere,
            this.PretPornire,
            this.Disponibil,
            this.nrOfertePlasate,
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(33, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(714, 322);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 100;
            // 
            // Descriere
            // 
            this.Descriere.Text = "Descriere";
            this.Descriere.Width = 150;
            // 
            // PretPornire
            // 
            this.PretPornire.Text = "Pret de pornire";
            this.PretPornire.Width = 120;
            // 
            // Disponibil
            // 
            this.Disponibil.Text = "Vandut";
            this.Disponibil.Width = 80;
            // 
            // nrOfertePlasate
            // 
            this.nrOfertePlasate.Text = "Oferte plasate";
            this.nrOfertePlasate.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Timp plasare";
            this.columnHeader1.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaTXTToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 28);
            // 
            // salveazaTXTToolStripMenuItem
            // 
            this.salveazaTXTToolStripMenuItem.Name = "salveazaTXTToolStripMenuItem";
            this.salveazaTXTToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.salveazaTXTToolStripMenuItem.Text = "Salveaza TXT";
            this.salveazaTXTToolStripMenuItem.Click += new System.EventHandler(this.salveazaTXTToolStripMenuItem_Click);
            // 
            // btnOferta
            // 
            this.btnOferta.Location = new System.Drawing.Point(776, 46);
            this.btnOferta.Name = "btnOferta";
            this.btnOferta.Size = new System.Drawing.Size(93, 82);
            this.btnOferta.TabIndex = 1;
            this.btnOferta.Text = "Plaseaza o oferta";
            this.btnOferta.UseVisualStyleBackColor = true;
            this.btnOferta.Click += new System.EventHandler(this.btnOferta_Click);
            // 
            // btnAdaugaProd
            // 
            this.btnAdaugaProd.Location = new System.Drawing.Point(910, 286);
            this.btnAdaugaProd.Name = "btnAdaugaProd";
            this.btnAdaugaProd.Size = new System.Drawing.Size(100, 82);
            this.btnAdaugaProd.TabIndex = 2;
            this.btnAdaugaProd.Text = "Adauga un produs";
            this.btnAdaugaProd.UseVisualStyleBackColor = true;
            this.btnAdaugaProd.Click += new System.EventHandler(this.btnAdaugaProd_Click);
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.Location = new System.Drawing.Point(764, 286);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(128, 82);
            this.btnInregistrare.TabIndex = 4;
            this.btnInregistrare.Text = "Inregistreaza-te ";
            this.btnInregistrare.UseVisualStyleBackColor = true;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
            // 
            // ObiecteLicitatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1165, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.btnAdaugaProd);
            this.Controls.Add(this.btnOferta);
            this.Controls.Add(this.listView1);
            this.Name = "ObiecteLicitatie";
            this.Text = "ObiecteLicitatie";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader Nume;
        private ColumnHeader Descriere;
        private ColumnHeader PretPornire;
        private ColumnHeader Disponibil;
        private Button btnOferta;
        private Button btnAdaugaProd;
        private ColumnHeader nrOfertePlasate;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnInregistrare;
        private ColumnHeader columnHeader1;
        private ToolStripMenuItem salveazaTXTToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
    }
}