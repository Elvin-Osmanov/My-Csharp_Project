using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LMS.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [Required]
        [StringLength(60)]
        public string Genre { get; set; }

        [Required]
        
        public int Quantity { get; set; }

        [Required]
        
        public double Price { get; set; }

    }
}
