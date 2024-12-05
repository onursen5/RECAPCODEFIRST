using Recap.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class ArabaEkleme : Form
    {
        private DatabaseContext _veritabani;
        public ArabaEkleme()
        {
            _veritabani = new DatabaseContext();
            InitializeComponent();
        }

        private void ArabaEkleme_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtParola.Text))
                MessageBox.Show("Kullanıcı adı ve parola boş bırakılamaz.");

                
                Cars araba = new Cars();
            araba.BrandID = Convert.ToInt32(txtBrandId.Text);
            araba.ColorID = Convert.ToInt32(txtColorId.Text);
            araba.ModelYear = Convert.ToInt32(txtModelYear.Text);
            araba.DailyPrice = Convert.ToInt32(txtDailyPrice.Text);
            araba.Description = txtDescription.Text;

            var arabaKontrol = _veritabani.Users.Where(c => c.FirstName.Equals(txtKullaniciAdi.Text)).SingleOrDefault();

            if (arabaKontrol is null)
            {
                _veritabani.Add(araba);
                int sonuc = _veritabani.SaveChanges();

                if (sonuc > 0)
                {
                    this.Hide();
                    ArabaListesi arabaListesi = new ArabaListesi();
                    arabaListesi.Show();
                }
                else
                {
                    MessageBox.Show("Araç Eklenemedi.");
                }
            }
        }
    }
}
