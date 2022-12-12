using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication221128.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleasedDate { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
    }
}
