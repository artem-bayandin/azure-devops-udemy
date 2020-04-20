using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
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

        public virtual ICollection<OrderLine> Orders { get; set; }

        [NotMapped]
        public string FullName => $"{Name} {Surname}";
    }
}
