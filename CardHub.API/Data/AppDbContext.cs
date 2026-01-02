using CardHub.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CardHub.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Card> Cards { get; set; }

    }
}