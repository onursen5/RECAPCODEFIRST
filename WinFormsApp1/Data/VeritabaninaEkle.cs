using WinFormsApp1.Data;

namespace Recap.Data
{
    public class VeritabaninaEkle
    {

        public static async Task Ekle  (DatabaseContext _veritabani)
        {
            await AracIslemleri.Olustur(_veritabani);
        }



    }
}
