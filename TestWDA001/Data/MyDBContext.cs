using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestWDA001.Models;

namespace TestWDA001.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("name=TestWDA")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}