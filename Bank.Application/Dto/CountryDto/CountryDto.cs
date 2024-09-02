using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Application.Dto.CountryDto
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
    }

    public class CreateCountryDto
    {
        
        public string CountryName { get; set; }
    }
}
