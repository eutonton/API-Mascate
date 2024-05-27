using System.ComponentModel.DataAnnotations.Schema;

namespace API_Mascate.Model.table
{
    [Table("table")]
    public class table
    {
        public int tableID { get; set; }
        public Boolean Availability { get; set; }
        public int Chairs { get; set; }

        public table(Boolean Availability, int Chairs)
        {
            this.Availability = Availability;
            this.Chairs = Chairs;
        }
    }

 
}
