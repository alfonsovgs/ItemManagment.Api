using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ItemManagment.Api.Models
{
    public class ItemDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Clasification> Clasifications { get; set; }

        public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
        }
    }
}
