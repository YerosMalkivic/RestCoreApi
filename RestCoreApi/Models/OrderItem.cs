using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestCoreApi.Models
{
    [Table("OrderItems")]
    public class OrderItem
    {

        [Column(Order = 1)]
        public Guid OrderID { get; set; }

        [Column(Order = 2)]
        public Guid ProductID { get; set; }

        public double Price { get; set; }
        public double Amount { get; set; }

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
