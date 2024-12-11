﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopApp.Infrastructure.Data.Domain
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string ProductName { get; set; }

        [Required]
        public string BrandId {  get; set; }

        public virtual Brand Brand { get; set; }

        [Required]
        public int CategoryId {  get; set; }

        public virtual Category Category { get; set; }

        public string Discription {  get; set; }

        public string Picture {  get; set; }

        [Range(0,5000)]
        public int Quantity {  get; set; }

        public decimal Price { get; set; }

        public decimal Discount {  get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    }
}
