using System.ComponentModel.DataAnnotations.Schema;

namespace API_Mascate.Model
{
    [Table("employee")]
    public class Employee
    {
        
        public int Id { get; set; }
        public string name { get; set; }
        public int reservationsMade { get; set; }

        public Employee(string name, int reservationsMade)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.reservationsMade = reservationsMade;
        }
    }

 
}
