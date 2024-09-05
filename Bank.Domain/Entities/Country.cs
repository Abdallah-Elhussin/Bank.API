using Bank.Domain.Common;


namespace Bank.Domain.Entities
{
    public class Country:BaseEntity
    {
       

        public string CountryName { get; set; } 
       
        public virtual ICollection<City> Cities { get; set; }
        public Country()
        {
            Cities = new List<City>();
        }

    }

}
