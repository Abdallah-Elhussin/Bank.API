using Microsoft.AspNetCore.Identity;


namespace Bank.Domain.Entities
{
    public class  AppUser: IdentityUser
    {
       
        public virtual ICollection<Clinet> Clinets { get; set; }
    }

}
