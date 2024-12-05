using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Recap.Models;
using WinFormsApp1.Models;

namespace WinFormsApp1.Data
{
    public class DatabaseContext: DbContext
    {

        public DatabaseContext()
        {

        }

        public DatabaseContext(string connectionString) : base(GetOptions(connectionString))
        {

        }

        private static DbContextOptions GetOptions (string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }

        public DbSet<Users> Users { get; set; }

        public DbSet<Cars> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server=ONUR;Database=Cars;user=sa;password=Bsktbl30924;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;Integrated Security=False;");
        }













    }
}
