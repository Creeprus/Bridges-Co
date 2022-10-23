
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace BridgesCoModels.Models
{
    public class OrderClient
    {
        [Key]
        public int Id_OrderClient { get; set; }
        [ForeignKey("Id_Order")]
        public Order Order_Id { get; set; }
        [ForeignKey("Id_Account")]
        public Account Account_Id{ get; set; }
        [JsonIgnore]
        public ICollection<OrderClient> OrderClientCollection { get; set; }
    }
}
