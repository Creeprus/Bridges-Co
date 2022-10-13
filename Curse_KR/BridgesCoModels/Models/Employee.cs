
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BridgesCoModels.Models
{
    public class Employee   
    {
        [Key]
        [ForeignKey("Account_Id")]
        public int Id_Employee { get; set; }
        [Required]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [AllowNull]
        [StringLength(50)]
        public string? Patronymic { get; set; }
        [Required]
        [StringLength(4)]
        public string Series_Passport { get; set; }
        [Required]
        [StringLength(6)]
        public string Number_Passport { get; set; }
        [ ForeignKey("Id_Role")]
        public Role Role_Id { get; set; }
        [Required]
        public Account Account_Id { get; set; }
    }
}
