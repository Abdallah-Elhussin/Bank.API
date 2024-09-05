using Bank.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;
using Bank.Domain.Entities;
using System.ComponentModel.DataAnnotations;


namespace Bank.Domain.Entities
{

    public class Clinet :BaseEntity{

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
       
        public string PersonalID { get; set; }
        public string ProfilePhoto { get; set; }

        public string MobileNumber { get; set; }
        [ForeignKey ("SexId")]
        public int SexId { get; set; }
        public virtual Sex sexType { get; set; }
        [ForeignKey("AccountID")]
        public int AccountID { get; set; }
        public virtual Account account { get; set; }

        [ForeignKey("StreetId")]
        public int StreetId {  get; set; }
        public virtual Street Street { get; set; }

        [ForeignKey("AppUserId")]
        public string AppUserId { get; set; }

        public virtual AppUser AppUser { get; set; }
    } 

}
