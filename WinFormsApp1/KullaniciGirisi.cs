using System.Security.Cryptography;
using System.Text;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class KullaniciGirisi : Form
    {
        private DatabaseContext _veritabani;
        public KullaniciGirisi()
        {
            _veritabani = new DatabaseContext();
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtParola.Text))
            {
                var musteri = _veritabani.Users.Where(c => c.FirstName.Equals(txtKullaniciAdi.Text) && c.PasswordHash.Equals(MD5IleSifrele(txtParola.Text))).SingleOrDefault();

                if (musteri != null)
                {
                    this.Hide();
                    ArabaListesi arabaListesi = new ArabaListesi();
                    arabaListesi.Show();
                }
                else
                {
                    MessageBox.Show("Kullan�c� ad� veya parola yanl��.");
                }
            }         
        } 
        private static string MD5IleSifrele(string parola)
            {
                // Bu metod ile, parametre olarak g�nderilen parolay�, okunamaz ve matematiksel olarak geri d�nd�r�lemez halde �ifreleyelim.
                // Bu t�r �ifrelemelerle kriptografi bilimi ilgilenir.
                return string.Join("", MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(parola)).Select(sifrelenmisParola => sifrelenmisParola.ToString("x2")));


            }
    }
}
