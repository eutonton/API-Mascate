using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Mascate.Model.reservation
{
    [Table("reservation")]
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        
        //Alterei
        [Required]
        public string name { get; set; }

        [Required]
        public int TableId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public string ClientCPF { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        // Construtor sem parâmetros
        public Reservation() { }

        public Reservation(int tableId, int employeeId, string clientCPF, DateTime dateTime)
        {
            TableId = tableId;
            EmployeeId = employeeId;
            ClientCPF = clientCPF ?? throw new ArgumentNullException(nameof(clientCPF));
            DateTime = dateTime;
        }
    }
}
