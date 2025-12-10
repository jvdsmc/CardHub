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

        // Aqui falamos pro banco: "Crie uma tabela chamada Cards baseada na classe Card"
        public DbSet<Card> Cards { get; set; }
    }
}