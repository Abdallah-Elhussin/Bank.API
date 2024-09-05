using Bank.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bank.Domain.Entities
{
    public class City : BaseEntity
    {

        public string Name { get; set; }  // Name of the city

        [ForeignKey("CountryId")]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }  // Navigation Property for the country

        // Navigation Property for related streets
        public virtual ICollection<Street> Streets { get; set; }
       
    }

}
