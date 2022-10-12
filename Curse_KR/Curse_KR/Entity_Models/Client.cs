using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Curse_Them_All_Courier.Entity_Models;

namespace Curse_KR.Entity_Models
{
    public class Client
    {
        [Key]
        [ForeignKey("Account_Id")]
        public int Id_Client { get; set; }
        [Required]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required, AllowNull]
        [StringLength(50)]
        public string Patronymic { get; set; }
        [Required]
        [StringLength(150)]
        public string Email { get; set; }
        [Required]
        [StringLength(30)]
        public string Phone_Number { get; set; }
        [Required]
        public Account Account_Id { get; set; }
    }
}
