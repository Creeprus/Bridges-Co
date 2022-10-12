using Curse_Them_All_Courier.Entity_Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Curse_KR.Entity_Models
{
    public class OrderClient
    {
        [Key]
        public int Id_OrderClient { get; set; }
        [ForeignKey("Id_Order")]
        public Order Order_Id { get; set; }
        [ForeignKey("Id_Account")]
        public Account Account_Id{ get; set; }
    }
}
