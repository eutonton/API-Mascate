using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Mascate.Model.employee
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(250, ErrorMessage = "Name length can't be more than 250.")]
        public string Name { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "ReservationsMade must be a non-negative number.")]
        public int ReservationsMade { get; set; }

        public Employee(string name, int reservationsMade)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            ReservationsMade = reservationsMade;
        }
    }
}

