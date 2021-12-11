using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestWDA001.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Hinhthuc { get; set; }
        public string Sotien { get; set; }
        public string Update_At { get; set; }
        public string PublicDate { get; set; }

    }
}
}