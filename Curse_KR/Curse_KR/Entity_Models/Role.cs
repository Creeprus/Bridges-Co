using System.ComponentModel.DataAnnotations;

namespace Curse_Them_All_Courier.Entity_Models
{
    public class Role
    {
        [Key]
        public int Id_Role { get; set; }
        [Required]
        [StringLength(30)]
        public string Role_Name { get; set; }
        
    }
}
