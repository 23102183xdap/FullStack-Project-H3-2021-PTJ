using System.ComponentModel.DataAnnotations;

namespace API.CDMRS.Models
{
    public class BasketItem : BaseModel
    {
        [Required]
        public BasketModel Basket { get; set; }

        [Required]
        public ItemModel Item { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
