using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestCoreApi.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductID { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }

        public double Price { get; set; }
    }
}
