using System.ComponentModel.DataAnnotations.Schema;

namespace API_Mascate.Model
{
    [Table("client")]
    public class Employee
    {

        public int clientId { get; set; }
        public string name { get; set; }
        public int CPF { get; set; }
        public int AbsenceCount { get; set; }

        public Employee(string name, int CPF, int AbsenceCount)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.CPF = CPF;
            this.AbsenceCount = AbsenceCount;
        }
    }
}