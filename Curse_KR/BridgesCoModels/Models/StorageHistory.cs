using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgesCoModels.Models
{
    public class StorageHistory
    {
        [Key]
        public int Id_StorageHistory { get; set; }
        [Required]
        [StringLength(250)]
        public string Description { get; set; }
        [Required]
        public DateTime Date_of_action { get; set; }
        [ForeignKey("Id_Storage")]
        public Storage Storage_Id { get; set; }
    }
}
