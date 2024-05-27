using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Mascate.Model.Client
{
    [Table("client")]
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name length can't be more than 100.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "CPF is required.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "CPF must be 11 digits.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "PhoneNuber is required.")]
        [RegularExpression(@"^\d{14}$", ErrorMessage = "PhoneNuber must be 14 digits.")]
        public string phoneNumber { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "AbsenceCount must be a non-negative number.")]
        public int AbsenceCount { get; set; }
        public Client() { }
        public Client(string name, string cpf, int absenceCount)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            CPF = cpf ?? throw new ArgumentNullException(nameof(cpf));
            AbsenceCount = absenceCount;
        }
    }
}