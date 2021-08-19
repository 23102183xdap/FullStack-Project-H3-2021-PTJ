using System;
using System.ComponentModel.DataAnnotations;

namespace API.CDMRS.Models
{
    public class CustomerModel : BaseModel
    {
        [Required]
        public LoginModel Login { get; set; }

        [Required]
        public CreditModel Credit { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Username can not be longer than 20 characters")]
        public string UserName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "FirstName can not be longer than 20 characters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "LastName can not be longer than 20 characters")]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDay { get; set; }

        [Required]
        [StringLength(64, ErrorMessage = "Address can not be longer than 64 characters")]
        public string AddressStreet { get; set; }

        [Required]
        public int AddressNumber { get; set; }

        [Required]
        public int AddressPostCode { get; set; }
    }
}
