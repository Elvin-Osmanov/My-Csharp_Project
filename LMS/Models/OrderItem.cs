﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }


    }
}
