using BacklogBonanza.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BacklogBonanza.API
{
    class BacklogBonanzaDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=tcp:backlog-bonanza.database.windows.net,1433;Initial Catalog=BacklogBonanzaDB;Persist Security Info=False;User ID={blablabla};Password={blablabla};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

    }
}