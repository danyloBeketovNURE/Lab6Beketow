using System.ComponentModel.DataAnnotations;

namespace Bank.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(10)]
        public string Telephone { get; set; }

        [Required, MinLength(5)]
        public string Password { get; set; }

        [Required]
        public double Money { get; set; }
    }
}
