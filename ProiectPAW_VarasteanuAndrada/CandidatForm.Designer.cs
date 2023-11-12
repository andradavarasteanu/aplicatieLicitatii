namespace ProiectPAW_VarasteanuAndrada
{
    partial class CandidatForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbCategorii = new System.Windows.Forms.TextBox();
            this.tbNrTel = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnAdaugaCandidat = new System.Windows.Forms.Button();
            this.btnListaCandidati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numar telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categorii de interes";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(338, 69);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(125, 27);
            this.tbNume.TabIndex = 5;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(338, 246);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(125, 27);
            this.tbAdresa.TabIndex = 6;
            // 
            // tbCategorii
            // 
            this.tbCategorii.Location = new System.Drawing.Point(338, 305);
            this.tbCategorii.Name = "tbCategorii";
            this.tbCategorii.Size = new System.Drawing.Size(125, 27);
            this.tbCategorii.TabIndex = 7;
            // 
            // tbNrTel
            // 
            this.tbNrTel.Location = new System.Drawing.Point(338, 179);
            this.tbNrTel.Name = "tbNrTel";
            this.tbNrTel.Size = new System.Drawing.Size(125, 27);
            this.tbNrTel.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(338, 125);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(125, 27);
            this.tbEmail.TabIndex = 9;
            // 
            // btnAdaugaCandidat
            // 
            this.btnAdaugaCandidat.Location = new System.Drawing.Point(88, 381);
            this.btnAdaugaCandidat.Name = "btnAdaugaCandidat";
            this.btnAdaugaCandidat.Size = new System.Drawing.Size(159, 29);
            this.btnAdaugaCandidat.TabIndex = 10;
            this.btnAdaugaCandidat.Text = "Adauga candidat";
            this.btnAdaugaCandidat.UseVisualStyleBackColor = true;
            this.btnAdaugaCandidat.Click += new System.EventHandler(this.btnAdaugaCandidat_Click);
            // 
            // btnListaCandidati
            // 
            this.btnListaCandidati.Location = new System.Drawing.Point(338, 381);
            this.btnListaCandidati.Name = "btnListaCandidati";
            this.btnListaCandidati.Size = new System.Drawing.Size(174, 29);
            this.btnListaCandidati.TabIndex = 11;
            this.btnListaCandidati.Text = "Vezi lista candidatilor";
            this.btnListaCandidati.UseVisualStyleBackColor = true;
            this.btnListaCandidati.Click += new System.EventHandler(this.btnListaCandidati_Click);
            // 
            // CandidatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.btnListaCandidati);
            this.Controls.Add(this.btnAdaugaCandidat);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNrTel);
            this.Controls.Add(this.tbCategorii);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CandidatForm";
            this.Text = "CandidatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbNume;
        private TextBox tbAdresa;
        private TextBox tbCategorii;
        private TextBox tbNrTel;
        private TextBox tbEmail;
        private Button btnAdaugaCandidat;
        private Button btnListaCandidati;
    }
}