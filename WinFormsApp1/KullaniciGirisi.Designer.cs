namespace WinFormsApp1
{
    partial class KullaniciGirisi
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
            lblKullaniciAdi = new Label();
            txtKullaniciAdi = new TextBox();
            lblParola = new Label();
            txtParola = new TextBox();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKullaniciAdi.Location = new Point(185, 178);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(115, 21);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(337, 178);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(188, 23);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // lblParola
            // 
            lblParola.AutoSize = true;
            lblParola.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblParola.Location = new Point(211, 232);
            lblParola.Name = "lblParola";
            lblParola.Size = new Size(67, 21);
            lblParola.TabIndex = 2;
            lblParola.Text = "Parola :";
            // 
            // txtParola
            // 
            txtParola.Location = new Point(337, 230);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(188, 23);
            txtParola.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGirisYap.Location = new Point(533, 323);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(75, 23);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // KullaniciGirisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGirisYap);
            Controls.Add(txtParola);
            Controls.Add(lblParola);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblKullaniciAdi);
            Name = "KullaniciGirisi";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKullaniciAdi;
        private TextBox txtKullaniciAdi;
        private Label lblParola;
        private TextBox txtParola;
        private Button btnGirisYap;
    }
}
