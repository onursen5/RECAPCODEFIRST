using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recap.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        public string? FirstName { get; set; }

        [Required]
        [Column(TypeName ="NVARCHAR(100)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName ="NVARCHAR(100)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName ="VARCHAR(50)")]
        public string PasswordHash { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string PasswordSalt { get; set; }

        [Required]
        [Column(TypeName ="BIT")]
        public bool Status { get; set; }


    }
}
