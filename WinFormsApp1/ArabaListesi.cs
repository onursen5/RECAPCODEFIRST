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

namespace WinFormsApp1
{
    public partial class ArabaListesi : Form
    {
        private DatabaseContext _veritabani;
        public ArabaListesi()
        {
            _veritabani = new DatabaseContext();
            InitializeComponent();
        }

        private void ArabaListesi_Load(object sender, EventArgs e)
        {
            dgvArabalar.DataSource = _veritabani.Cars.ToList();
            dgvArabalar.ReadOnly = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            ArabaEkleme arabaEkleme = new ArabaEkleme();
            arabaEkleme.Show();
        }
    }
}
