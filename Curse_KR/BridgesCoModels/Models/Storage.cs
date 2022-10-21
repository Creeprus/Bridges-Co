using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BridgesCoModels.Models
{
    public class Storage
    {
        [Key]
        public int Id_Storage { get; set; }
        [Required]
        public int Amount { get; set; }
        [ForeignKey ("Id_Shipment")]
        public Shipment Shipment_Id { get; set; }
        [ForeignKey ("Id_Supply"), AllowNull]
        public Supply Supply_Id { get; set; }
        public ICollection<Storage> StorageCollection { get; set; }
    }
}
