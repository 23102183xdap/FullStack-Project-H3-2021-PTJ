using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.CDMRS.Models
{
    public class OrderModel
    {
        [Required]
        public CustomerModel Customer { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
    }
}
