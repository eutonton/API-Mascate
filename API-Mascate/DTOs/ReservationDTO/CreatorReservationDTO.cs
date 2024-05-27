namespace API_Mascate.DTOs.ReservationDTO
{
    public class CreatorReservationDTO
    { 
        public int TableId { get; set; }
        public int EmployeeId { get; set; }
        public string name { get; set; }
        public string ClientCPF { get; set; }
        public DateTime DateTime { get; set; }

    }
}