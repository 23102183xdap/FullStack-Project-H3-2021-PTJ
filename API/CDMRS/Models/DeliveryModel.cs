using System.ComponentModel.DataAnnotations;


namespace API.CDMRS.Models
{
    public class DeliveryModel : BaseModel
    {
        [Required]
        public OrderModel Order { get; set; }

        [Required]
        [StringLength(128, ErrorMessage = "Status message can not be longer than 128 characters")]
        public string Status { get; set; }
    }
}
