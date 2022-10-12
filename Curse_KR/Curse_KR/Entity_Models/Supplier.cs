using System.ComponentModel.DataAnnotations;

namespace Curse_KR.Entity_Models
{
    public class Supplier
    {
        [Key]
        public int Id_Supplier { get; set; }
        [Required]
        [StringLength(50)]
        public string Country { get; set; }
        [Required]
        [StringLength(100)]
        public string Supplier_Name { get;set; }
       

    }
}
