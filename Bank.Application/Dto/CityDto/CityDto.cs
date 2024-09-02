using Bank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Application.Dto.CityDto
{
    public class CityDto
    {
        public string Name { get; set; }
        [Required] 
        public int CountryId { get; set; }
        public  string CountryName { get; set; }
    
}
}
