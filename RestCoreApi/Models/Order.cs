using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestCoreApi.Models
{
    [Table("Orders")]
    public class Order
    {

        public Order()
        {
            CreatedDate = DateTime.Now;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderID { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public string Description { get; set; }

        public double Total { 
            get {
                double aux_total = 0;
                foreach(OrderItem item in OrderItems)
                {
                    aux_total += item.Price * item.Amount;
                }
                return aux_total;
            } 
            private set { Total = value; } }

        public virtual ICollection<OrderItem> OrderItems { get; set; }

        [InverseProperty("Orders")]
        public virtual Customer Customer { get; set; }
    }
}
