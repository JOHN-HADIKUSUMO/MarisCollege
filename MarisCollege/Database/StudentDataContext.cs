using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using MarisCollege.Models;

namespace MarisCollege.Database
{
    public class StudentDataContext:DbContext
    {
        private readonly IConfiguration configuration;
        public DbSet<Student> Students { get; set; }
        public StudentDataContext(IConfiguration configuration,DbContextOptions<StudentDataContext> options)
                   : base(options)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
