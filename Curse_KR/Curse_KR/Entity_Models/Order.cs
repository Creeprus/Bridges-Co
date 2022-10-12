﻿using Curse_Them_All_Courier.Entity_Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Curse_KR.Entity_Models
{
    public class Order
    {
        [Key]
        public int Id_Order { get; set; }
    [Required]
    public DateTime Date_Order { get; set; }
        [Required]
        public DateTime Date_Depart{ get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public decimal Summary { get; set; }
        [ ForeignKey("Id_Account")]
        public Account Account_Id { get; set; }
        [ForeignKey("Id_Shipment")]
        public Shipment Shipment_Id { get; set; }
    }
}
