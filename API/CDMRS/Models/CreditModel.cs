using System.ComponentModel.DataAnnotations.Schema;

namespace API.CDMRS.Models
{
    public class CreditModel : BaseModel
    {
        [Column(TypeName = "decimal(18,4)")]
        public decimal CreditAmount { get; set; }
    }
}
