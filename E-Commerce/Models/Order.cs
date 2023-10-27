﻿using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using E_Commerce.Models;

namespace MVC_Project.Models
{
    public enum OrderStatus
    {
        Shipped,
        Pending,
        Delivered,
        Canceled
    }
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(255)] 
        public string? Address { get; set; }

        [MaxLength(255)]
        public string? Street { get; set; }
        [MaxLength(255)]
        public string? City { get; set; }
        [MaxLength(255)]
        public string? Country { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User? User { get; set; }

        public OrderStatus Status { get; set; } 

        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        [Column(TypeName = "money")]    
        public decimal TotalPrice { get; set; }

        [ForeignKey("Cart")]
        public int cart_id { get; set; }
        public virtual Cart? Cart { get; set; }

    }

}
