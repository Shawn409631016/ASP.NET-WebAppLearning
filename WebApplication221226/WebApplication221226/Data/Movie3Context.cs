using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication221226.Models;

namespace WebApplication221226.Data
{
    public class Movie3Context : DbContext
    {
        public Movie3Context(DbContextOptions<Movie3Context> options) : base(options)
        {

        }
        public DbSet<Movie3> Movie3 { get; set; }
    }
}
