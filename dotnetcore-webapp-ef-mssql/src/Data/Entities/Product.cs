using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

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
    }

    public class Person
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        [StringLength(100, MinimumLength = 2)]
        public string Surname { get; set; }

        [Range(0, 150)]
        public int Age { get; set; }
    }
}
