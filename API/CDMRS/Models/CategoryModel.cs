using System.ComponentModel.DataAnnotations;

namespace API.CDMRS.Models
{
    public class CategoryModel : BaseModel
    {
        [Required]
        public string Name { get; set; }
    }
}
