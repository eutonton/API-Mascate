using System.ComponentModel.DataAnnotations.Schema;

namespace API_Mascate.Model.client
{
    [Table("client")]
    public class Client
    {

        public int clientId { get; set; }
        public string name { get; set; }
        public int CPF { get; set; }
        public int AbsenceCount { get; set; }

        public Client(string name, int CPF, int AbsenceCount)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.CPF = CPF;
            this.AbsenceCount = AbsenceCount;
        }
    }
}