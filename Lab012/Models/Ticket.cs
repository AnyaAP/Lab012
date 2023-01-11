using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Lab012.Models
{
    public class Ticket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PassId { get; set; }
        public int TrainId { get; set; }
        public int Railcar { get; set; }
        public int Seat { get; set; }
        public string StartPlace { get; set; }
        public string FinalPlace { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinalDate { get; set; }
    }
}
