using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace techPhoneApplication.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Currency { get; set; } = "PHP";
        public string Description { get; set; }
        public DateTime ManufactureDate { get; set; }

    }
}
