using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Domain.Entities;

namespace Bank.Application.Dto.ClinetDto
{
    public class ClinetDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(60)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required, StringLength(11, ErrorMessage = "Personal ID must be exactly 11 characters.", MinimumLength = 11)]
        public string PersonalID { get; set; }
        public string ProfilePhoto { get; set; }

        [Required(ErrorMessage = "Mobile number is required.")]
        [RegularExpression(@"^\+?\d{10,15}$", ErrorMessage = "Invalid mobile number. It should include the country code and be 10 to 15 digits long.")]
        public string MobileNumber { get; set; }
       
    }
    public class CreateClinetDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PersonalID { get; set; }
     //   public string ProfilePhoto { get; set; }
        public string MobileNumber { get; set; }



    }
}

