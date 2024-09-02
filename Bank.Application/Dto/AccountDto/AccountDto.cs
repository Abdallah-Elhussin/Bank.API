using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Application.Dto.AccountDto
{
    public class AccountDto
    {
        public int Id { get; set; }
        public string NumberAccount { get; set; }
        public string NameAccount { get; set; }
    }

    public class CreateAccountDto
    {
        [Required]
        public string NumberAccount { get; set; }
        [Required]
        public string NameAccount { get; set; }
    }
}
