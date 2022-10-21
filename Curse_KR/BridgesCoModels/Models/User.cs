using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;


namespace BridgesCoModels.Models
{
    public class User
    {
        [Key]
        [ForeignKey("Account_Id")]
        public int Id_User { get; set; }
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
        [StringLength(150)]
        public string Email { get; set; }
        
        [StringLength(30)]
        public string Phone_Number { get; set; }
       
        [StringLength(4)]
        public string? Series_Passport { get; set; }
       
        [StringLength(6)]
        public string? Number_Passport { get; set; }
        [Required]
        [ForeignKey("Id_Role")]
        public Role Role_Id { get; set; }
        [Required]
        public Account Account_Id { get; set; }

        public ICollection<User> UserCollection { get; set; }
    }
}
