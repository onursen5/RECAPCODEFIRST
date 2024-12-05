namespace WinFormsApp1
{
    partial class ArabaListesi
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
            btnEkle = new Button();
            dgvArabalar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvArabalar).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(826, 569);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(101, 23);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Araba Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvArabalar
            // 
            dgvArabalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArabalar.Location = new Point(4, 22);
            dgvArabalar.Name = "dgvArabalar";
            dgvArabalar.Size = new Size(923, 541);
            dgvArabalar.TabIndex = 3;
            // 
            // ArabaListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 618);
            Controls.Add(dgvArabalar);
            Controls.Add(btnEkle);
            Name = "ArabaListesi";
            Text = "ArabaListesi";
            Load += ArabaListesi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArabalar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnEkle;
        private DataGridView dgvArabalar;
    }
}