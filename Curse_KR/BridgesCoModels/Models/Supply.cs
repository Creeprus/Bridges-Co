using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace BridgesCoModels.Models
{ 
    public class Supply
    {
        [Key]
        public int Id_Supply { get; set; }
        [Required]
        public DateTime Date_of_supply { get; set; }
        [ForeignKey("Id_Supplier")]
        public Supplier Supplier_Id { get; set; }
     
        
    }
}
