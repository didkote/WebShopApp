﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopApp.Infrastructure.Data.Domain
{
    public class Brand
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string BrandName { get; set; }

        public virtual ICollection<Product> products { get; set; } = new List<Product>();

    }
}
