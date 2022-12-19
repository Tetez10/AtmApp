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


        [ForeignKey("Transactions")]

        public int Transactieid { get; set; }
        public Transactions Transactions { get; set; }

    }
}
