using System.ComponentModel.DataAnnotations;

namespace BridgesCoModels.Models
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
