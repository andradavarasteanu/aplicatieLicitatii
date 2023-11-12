namespace ProiectPAW_VarasteanuAndrada
{
    partial class ListaCandidatiForm
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
            this.btnPreluareDate = new System.Windows.Forms.Button();
            this.lvCandidati = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.nume = new System.Windows.Forms.ColumnHeader();
            this.email = new System.Windows.Forms.ColumnHeader();
            this.nrTelefon = new System.Windows.Forms.ColumnHeader();
            this.adresa = new System.Windows.Forms.ColumnHeader();
            this.categoriiDeInteres = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnPreluareDate
            // 
            this.btnPreluareDate.Location = new System.Drawing.Point(151, 369);
            this.btnPreluareDate.Name = "btnPreluareDate";
            this.btnPreluareDate.Size = new System.Drawing.Size(149, 29);
            this.btnPreluareDate.TabIndex = 1;
            this.btnPreluareDate.Text = "Preluare date";
            this.btnPreluareDate.UseVisualStyleBackColor = true;
            this.btnPreluareDate.Click += new System.EventHandler(this.btnPreluareDate_Click);
            // 
            // lvCandidati
            // 
            this.lvCandidati.CheckBoxes = true;
            this.lvCandidati.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.nume,
            this.email,
            this.nrTelefon,
            this.adresa,
            this.categoriiDeInteres});
            this.lvCandidati.FullRowSelect = true;
            this.lvCandidati.GridLines = true;
            this.lvCandidati.Location = new System.Drawing.Point(86, 61);
            this.lvCandidati.Name = "lvCandidati";
            this.lvCandidati.Size = new System.Drawing.Size(723, 260);
            this.lvCandidati.TabIndex = 2;
            this.lvCandidati.UseCompatibleStateImageBehavior = false;
            this.lvCandidati.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // nume
            // 
            this.nume.Text = "Nume";
            this.nume.Width = 100;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 100;
            // 
            // nrTelefon
            // 
            this.nrTelefon.Text = "nrTelefon";
            // 
            // adresa
            // 
            this.adresa.Text = "Adresa";
            // 
            // categoriiDeInteres
            // 
            this.categoriiDeInteres.Text = "categoriiDeInteres";
            this.categoriiDeInteres.Width = 250;
            // 
            // ListaCandidatiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.lvCandidati);
            this.Controls.Add(this.btnPreluareDate);
            this.Name = "ListaCandidatiForm";
            this.Text = "ListaCandidatiForm";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnPreluareDate;
        private ListView lvCandidati;
        private ColumnHeader ID;
        private ColumnHeader nume;
        private ColumnHeader email;
        private ColumnHeader nrTelefon;
        private ColumnHeader adresa;
        private ColumnHeader categoriiDeInteres;
    }
}