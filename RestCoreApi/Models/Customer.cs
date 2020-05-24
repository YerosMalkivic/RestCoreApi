using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestCoreApi.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CustomerId { get; set; }

        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(25)]
        public string Email { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
