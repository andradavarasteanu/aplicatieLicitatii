namespace ProiectPAW_VarasteanuAndrada
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVeziProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVeziProd
            // 
            this.btnVeziProd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVeziProd.Location = new System.Drawing.Point(184, 294);
            this.btnVeziProd.Name = "btnVeziProd";
            this.btnVeziProd.Size = new System.Drawing.Size(227, 59);
            this.btnVeziProd.TabIndex = 0;
            this.btnVeziProd.Text = "Vezi produsele din cadrul licitatiei";
            this.btnVeziProd.UseVisualStyleBackColor = false;
            this.btnVeziProd.Click += new System.EventHandler(this.btnVeziProd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.btnVeziProd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnVeziProd;
    }
}