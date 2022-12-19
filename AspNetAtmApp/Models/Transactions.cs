using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetAtmApp.Models
{
    public class Transactions
    {

   
        public int Transactieid { get; set; }

        public string firstname { get; set; }
        

        public string lastname { get; set; }

        public string type { get; set; }


        public string Amount { get; set; }

        public int newsaldo { get; set; }
    }
}
