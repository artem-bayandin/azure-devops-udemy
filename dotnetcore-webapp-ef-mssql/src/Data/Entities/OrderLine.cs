using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class OrderLine
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        public Guid BuyerId { get; set; }
        public virtual Person Buyer { get; set; }

        [Required]
        [Range(0, 100)]
        public int Quantity { get; set; }
    }
}
