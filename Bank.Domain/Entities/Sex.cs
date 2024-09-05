using Bank.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Domain.Entities
{
    public class Sex : BaseEntity
    {
        //public enum SexType
        //{
        //    Male,
        //    Female
        //}

        public virtual string SexType { get; set; } // Type of the Sex
        public virtual ICollection<Clinet> Clinets { get; set; }
    }
}
