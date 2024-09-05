using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Domain.Common
{
    public class BaseEntity
    {

        public int Id { get; set; }

        public string CreateBy { get; set; } = string.Empty;
        public DateTime CreaetAt { get; set; }= DateTime.Now;
        public string EditBy { get; set; } = string.Empty ;
        public DateTime EditAt { get; set; }
        public bool IsDelete { get; set; }=false;
       // public bool? Visible { get; set; } = false;

    }
}
