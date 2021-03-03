using Microsoft.EntityFrameworkCore;
using RMotownFestival.Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMotownFestival.Api.DAL
{
    public class MotownDbContext : DbContext
    {
        public MotownDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Stage> Stages { get; set; }
    }
}
