using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Range(0, 10000)]
        public double Price { get; set; }

        public virtual ICollection<OrderLine> Orders { get; set; }
    }
}
