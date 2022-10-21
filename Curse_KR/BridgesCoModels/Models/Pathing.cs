using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgesCoModels.Models
{
    public class Pathing
    {
        [Key]
        [ForeignKey("Order_Id")]
        public int Id_Pathing { get; set; }
        [Required]
        [StringLength(5)]
        public string Path_time { get; set; }
        [Required]
        [StringLength(200)]
        public string Adress { get; set; }
        [Required]
        [StringLength(100)]
        public string Transport { get; set; }
        [Required]
        public Order Order_Id { get; set; }

        public ICollection<Pathing> PathingCollection { get; set; }
    }
}
