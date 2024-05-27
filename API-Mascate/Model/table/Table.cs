using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Mascate.Model.table
{
    [Table("table")]
    public class Table
    {
        [Key]
        public int TableID { get; set; }

        [Required]
        public bool Availability { get; set; }

        [Range(1, 20, ErrorMessage = "Number of chairs must be between 1 and 20.")]
        public int Chairs { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Size { get; set; }

        public Table(bool availability, int chairs, string type, string size)
        {
            Availability = availability;
            Chairs = chairs;
            Type = type;
            Size = size;
        }
    }
}