﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BabyInABagServer.Models
{
    public class Order
    {
        [Key]
        [Display(Name = "Order Id")]
        public int Order_Id { get; set; }

        [Display(Name ="Order Number")]
        public string Order_Number { get; set; }
    
        [Display(Name = "Order Placed")]
        public System.DateTime Order_Date_Placed { get; set; }

        [Display(Name = "Order Status")]
        public Order_Status Order_Status { get; set; }

        [Display(Name = "Order Total")]
        public decimal Order_Total { get; set; }

        [Display(Name = "Full Name")]
        public string Full_Name { get; set; }

        [Display(Name = "Shipping Address")]
        public string Shipping_Address { get; set; }

        [ForeignKey("Customer")]
        public int Customer_Id { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
    public enum Order_Status {Submitted,Pending,Processing,Ongoing,Completed,Rejected,Refunded}
}