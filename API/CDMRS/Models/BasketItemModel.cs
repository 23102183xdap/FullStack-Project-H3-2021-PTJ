using System.ComponentModel.DataAnnotations;

namespace API.CDMRS.Models
{
    public class BasketItemModel : BaseModel
    {
        [Required]
        public BasketModel Basket { get; set; }

        [Required]
        public ItemModel Item { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
