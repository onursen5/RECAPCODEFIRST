using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp1.Models
{
    public class Cars
    {
        [Key]
        public int ID { get; set; }

        public int BrandID {  get; set; }
        public int ColorID { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }

        [Column(TypeName ="VARCHAR(100)")]
        public string Description { get; set; }
    }
}
