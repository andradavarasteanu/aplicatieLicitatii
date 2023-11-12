namespace ProiectPAW_VarasteanuAndrada
{
    partial class PlaseazaOfertaForm
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
            this.tbNumeCandidat = new System.Windows.Forms.TextBox();
            this.tbSumaOferita = new System.Windows.Forms.TextBox();
            this.btnPlaseaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume candidat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Suma oferita";
            // 
            // tbNumeCandidat
            // 
            this.tbNumeCandidat.Location = new System.Drawing.Point(242, 94);
            this.tbNumeCandidat.Name = "tbNumeCandidat";
            this.tbNumeCandidat.Size = new System.Drawing.Size(125, 27);
            this.tbNumeCandidat.TabIndex = 2;
            // 
            // tbSumaOferita
            // 
            this.tbSumaOferita.Location = new System.Drawing.Point(242, 164);
            this.tbSumaOferita.Name = "tbSumaOferita";
            this.tbSumaOferita.Size = new System.Drawing.Size(125, 27);
            this.tbSumaOferita.TabIndex = 3;
            // 
            // btnPlaseaza
            // 
            this.btnPlaseaza.Location = new System.Drawing.Point(152, 302);
            this.btnPlaseaza.Name = "btnPlaseaza";
            this.btnPlaseaza.Size = new System.Drawing.Size(125, 29);
            this.btnPlaseaza.TabIndex = 4;
            this.btnPlaseaza.Text = "Plaseaza";
            this.btnPlaseaza.UseVisualStyleBackColor = true;
            this.btnPlaseaza.Click += new System.EventHandler(this.btnPlaseaza_Click);
            // 
            // PlaseazaOfertaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 394);
            this.Controls.Add(this.btnPlaseaza);
            this.Controls.Add(this.tbSumaOferita);
            this.Controls.Add(this.tbNumeCandidat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PlaseazaOfertaForm";
            this.Text = "PlaseazaOfertaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbNumeCandidat;
        private TextBox tbSumaOferita;
        private Button btnPlaseaza;
    }
}