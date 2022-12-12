using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 221128MVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime TeleasedDate { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
    }
}
