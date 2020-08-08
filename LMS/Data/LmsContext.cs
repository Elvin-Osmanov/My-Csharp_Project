using System;
using System.Collections.Generic;
using System.Text;
using LMS.Models;
using Microsoft.EntityFrameworkCore;

namespace LMS.Data
{
    public class LmsContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlServer(@"Server=LAPTOP-CJLQLU25;Database=LMS;Integrated Security=True");


        public DbSet<Administrator> Administrators { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<Report> Reports { get; set; }


    }
}
