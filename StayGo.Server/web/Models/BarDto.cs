using System.ComponentModel.DataAnnotations;

namespace staygo_server.Models
{
    public class BarDto
    {
        [Required] public int Id { get; set; }
        [Required] public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public byte Rating { get; set; }
        public double AvgPayCheck { get; set; }
    }
}