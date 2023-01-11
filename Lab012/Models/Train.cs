using System.ComponentModel.DataAnnotations.Schema;

namespace Lab012.Models
{
    public class Train
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Number { get; set; }
        public int Railcars { get; set; }
        public string TrainType { get; set; }
    }
}
