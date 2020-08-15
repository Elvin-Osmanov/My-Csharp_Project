using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LMS.Models
{
    public class Order
    {
        public int Id { get; set; }

        
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(TypeName = "date")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime ReturnDate { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal OrderPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? Fine { get; set; }

        public IList<OrderItem> OrderItem { get; set; }


    }
}
