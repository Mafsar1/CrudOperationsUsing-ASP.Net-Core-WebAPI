using Microsoft.EntityFrameworkCore;
using SuperHeroAPIDotNet7.Models;
using System.Collections.Generic;

namespace SuperHeroAPIDotNet7.Data
{
    public class DataContext:DbContext
    {
            public DataContext(DbContextOptions<DataContext> options) : base(options)
            {

            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);
                
            }

            public DbSet<SuperHero> SuperHeroes { get; set; }
        }
}
