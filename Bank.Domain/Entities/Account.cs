using Bank.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Domain.Entities
{
    public class Account : BaseEntity
    {
        
        public string NumberAccount { get; set; }
        
        public string NameAccount { get; set; }
        public virtual ICollection<Clinet> Clinets { get; set; }
    }
}
