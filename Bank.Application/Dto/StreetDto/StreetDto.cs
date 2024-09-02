using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Application.Dto.StreetDto
{
    public class StreetDto
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
    }
    public class CreateStreetDto
    {
        public string StreetName { get; set; }
    }
}
