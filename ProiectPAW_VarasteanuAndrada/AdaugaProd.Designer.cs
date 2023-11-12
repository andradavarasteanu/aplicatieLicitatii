namespace ProiectPAW_VarasteanuAndrada
{
    partial class AdaugaProd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumeObiect = new System.Windows.Forms.TextBox();
            this.tbDescriere = new System.Windows.Forms.TextBox();
            this.tbPretPornire = new System.Windows.Forms.TextBox();
            this.rbDA = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbVandut = new System.Windows.Forms.GroupBox();
            this.rbNU = new System.Windows.Forms.RadioButton();
            this.btnAdaugaObLaLic = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbVandut.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume obiect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descriere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pret de pornire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vandut";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Timp plasare";
            // 
            // tbNumeObiect
            // 
            this.tbNumeObiect.Location = new System.Drawing.Point(219, 61);
            this.tbNumeObiect.Name = "tbNumeObiect";
            this.tbNumeObiect.Size = new System.Drawing.Size(125, 27);
            this.tbNumeObiect.TabIndex = 6;
            // 
            // tbDescriere
            // 
            this.tbDescriere.Location = new System.Drawing.Point(219, 105);
            this.tbDescriere.Name = "tbDescriere";
            this.tbDescriere.Size = new System.Drawing.Size(125, 27);
            this.tbDescriere.TabIndex = 7;
            // 
            // tbPretPornire
            // 
            this.tbPretPornire.Location = new System.Drawing.Point(219, 152);
            this.tbPretPornire.Name = "tbPretPornire";
            this.tbPretPornire.Size = new System.Drawing.Size(125, 27);
            this.tbPretPornire.TabIndex = 8;
            // 
            // rbDA
            // 
            this.rbDA.AutoSize = true;
            this.rbDA.Location = new System.Drawing.Point(0, 41);
            this.rbDA.Name = "rbDA";
            this.rbDA.Size = new System.Drawing.Size(51, 24);
            this.rbDA.TabIndex = 10;
            this.rbDA.TabStop = true;
            this.rbDA.Text = "DA";
            this.rbDA.UseVisualStyleBackColor = true;
            // 
            // gbVandut
            // 
            this.gbVandut.Controls.Add(this.rbNU);
            this.gbVandut.Controls.Add(this.rbDA);
            this.gbVandut.Location = new System.Drawing.Point(139, 261);
            this.gbVandut.Name = "gbVandut";
            this.gbVandut.Size = new System.Drawing.Size(250, 125);
            this.gbVandut.TabIndex = 11;
            this.gbVandut.TabStop = false;
            this.gbVandut.Text = "Produsul este vandut?";
            // 
            // rbNU
            // 
            this.rbNU.AutoSize = true;
            this.rbNU.Checked = true;
            this.rbNU.Location = new System.Drawing.Point(108, 41);
            this.rbNU.Name = "rbNU";
            this.rbNU.Size = new System.Drawing.Size(51, 24);
            this.rbNU.TabIndex = 11;
            this.rbNU.TabStop = true;
            this.rbNU.Text = "NU";
            this.rbNU.UseVisualStyleBackColor = true;
            // 
            // btnAdaugaObLaLic
            // 
            this.btnAdaugaObLaLic.Location = new System.Drawing.Point(458, 323);
            this.btnAdaugaObLaLic.Name = "btnAdaugaObLaLic";
            this.btnAdaugaObLaLic.Size = new System.Drawing.Size(203, 29);
            this.btnAdaugaObLaLic.TabIndex = 13;
            this.btnAdaugaObLaLic.Text = "Adauga obiect";
            this.btnAdaugaObLaLic.UseVisualStyleBackColor = true;
            this.btnAdaugaObLaLic.Click += new System.EventHandler(this.btnAdaugaObLaLic_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(518, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // AdaugaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 456);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAdaugaObLaLic);
            this.Controls.Add(this.gbVandut);
            this.Controls.Add(this.tbPretPornire);
            this.Controls.Add(this.tbDescriere);
            this.Controls.Add(this.tbNumeObiect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugaProd";
            this.Text = "AdaugaProd";
            this.gbVandut.ResumeLayout(false);
            this.gbVandut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox tbNumeObiect;
        private TextBox tbDescriere;
        private TextBox tbPretPornire;
        private RadioButton rbDA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox gbVandut;
        private RadioButton rbNU;
        private Button btnAdaugaObLaLic;
        private DateTimePicker dateTimePicker1;
    }
}