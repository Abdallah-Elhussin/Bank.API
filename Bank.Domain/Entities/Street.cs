using Bank.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bank.Domain.Entities
{
    public class Street : BaseEntity
    {
       
        public string StreetName { get; set; }  // Name of the street

        [ForeignKey("CityId")]
        public int CityId { get; set; }
        public virtual City City { get; set; }  // Navigation Property for the city

        public virtual ICollection<Clinet> Clinets { get; set; }
    }

}
