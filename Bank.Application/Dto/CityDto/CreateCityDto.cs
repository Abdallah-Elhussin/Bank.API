using System.ComponentModel.DataAnnotations;

namespace Bank.Application.Dto.CityDto
{
    public class CreateCityDto
    {
        public string Name { get; set; }

        public int CountryId { get; set; }
    }
}
