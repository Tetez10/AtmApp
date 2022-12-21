using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetAtmApp.Models
{
    public class User
    {
        
        public int id { get; set; }

        public string Firstname { get; set; }
        
        public string Lastname { get; set; }

        public string Email { get; set; }


        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public int Trid { get; set; }


        [ForeignKey("Trid")]

        public Transactions Transactions {get; set; }
       

    }
}
