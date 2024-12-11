﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WebShopApp.Infrastructure.Data.Domain
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public int ProductId {  get; set; }
        public virtual Product Product { get; set; }


        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; } = null!;

        public int Quantity {  get; set; }
        public decimal Price {  get; set; }
        public decimal Discount { get; set; }   
        public decimal TotalPrice { get { return Quantity * Price - Quantity * Price * Discount / 100; } }
    }
}
