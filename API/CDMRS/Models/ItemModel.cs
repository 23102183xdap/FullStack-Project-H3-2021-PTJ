using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.CDMRS.Models
{
    public class ItemModel : BaseModel
    {
        public ItemModel()
        {
            Tags = new();
        }

        [Required]
        public string ItemType { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Discount { get; set; }

        [Required]
        [StringLength(5000, ErrorMessage = "Item description can not be more than 5000 chars")]
        public string Discription { set; get; }

        public string Image { get; set; }

        public List<CategoryModel> Tags { get; set; }
    }
}
