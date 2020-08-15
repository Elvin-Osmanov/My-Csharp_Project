using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LMS.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        
        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [StringLength(60)]
        public string Author { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public double PricePerWeek { get; set; }

        [Required]
        public int Quantity { get; set; }

        public IList<OrderItem> OrderItem { get; set; }

        [Required]
        public int Shelf { get; set; }

    }
}
