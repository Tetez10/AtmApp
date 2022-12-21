using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetAtmApp.Models
{
    public class Transactions
    {

   
        public int id { get; set; }

        public int Trid { get; set; }

        public string firstname { get; set; }
        

        public string lastname { get; set; }

        public string type { get; set; }


        public string Amount { get; set; }

        public int newsaldo { get; set; }
    }
}
