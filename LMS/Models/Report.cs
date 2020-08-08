using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LMS.Models
{
    public class Report
    {
        public int Id { get; set; }

        [Required]
        
        public DateTime StartDate { get; set; }

        [Required]
       
        public DateTime EndDate { get; set; }
    }
}
