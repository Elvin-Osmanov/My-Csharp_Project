using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LMS.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [Required]
        [StringLength(60)]
        public string Surname { get; set; }

        [Required]
        [StringLength(60)]
        public string PhoneNumber { get; set; }

        public List<Order> Order { get; set; }


    }
}
