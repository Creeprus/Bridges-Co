using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace BridgesCoModels.Models
{
    public class Shipment
    {
        [Key]
        public int Id_Shipment { get; set; }
        [Required]
        [StringLength(100)]
        public string Shipment_Name { get; set; }
        [Required]
        public DateTime Date_Arrive { get; set; }
        [AllowNull]
        public DateTime? Expiration_Date { get; set; }
        [Required]
        public decimal Cost { get; set; }
        [JsonIgnore]
        public ICollection<Shipment> ShipmentCollection { get; set; }
    }
}
