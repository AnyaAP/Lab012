using System.ComponentModel.DataAnnotations.Schema;

namespace Lab012.Models
{
    public class Passenger
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string PassName { get; set; }
        public int Passport { get; set; }
    }
}
