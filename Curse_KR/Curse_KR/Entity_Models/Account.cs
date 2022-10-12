using System.ComponentModel.DataAnnotations;

namespace Curse_Them_All_Courier.Entity_Models
{
    public class Account
    {
        [Key]
        public int Id_Account { get; set; }
        [Required]
        [StringLength(50)]
        public string Login { get; set; }
        [Required]
        [StringLength(256)]
        public string Password { get; set; }
    }
}
