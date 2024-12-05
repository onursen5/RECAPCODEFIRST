using Recap.Models;
using System.Security.Cryptography;
using System.Text;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace Recap.Data
{
    public class AracIslemleri
    {

        public static async Task Olustur(DatabaseContext _veritabani)
        {
            if (!_veritabani.Users.Any())
            {
                var kullanici = new Users
                {
                    FirstName = "Onur",
                    LastName = "ŞEN",
                    Email = "onursen5789@gmail.com",
                    PasswordHash = MD5IleSifrele("1234567"),
                    PasswordSalt = MD5IleSifrele("1234567"),
                    Status = true
                };

                _veritabani.Users.Add(kullanici);
                await _veritabani.SaveChangesAsync();
            }
        }
        private static string MD5IleSifrele(string parola)
        {
            // Bu metod ile, parametre olarak gönderilen parolayı, okunamaz ve matematiksel olarak geri döndürülemez halde şifreleyelim.
            // Bu tür şifrelemelerle kriptografi bilimi ilgilenir.
            return string.Join("", MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(parola)).Select(sifrelenmisParola => sifrelenmisParola.ToString("x2")));


        }


    }
}
