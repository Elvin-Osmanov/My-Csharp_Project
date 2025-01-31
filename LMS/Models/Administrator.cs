﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LMS.Models
{
    public class Administrator
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
        public string Username { get; set; }

        [Required]
        [StringLength(60)]
        public string Password { get; set; }
    }
}
