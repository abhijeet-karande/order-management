using Instient.Models;
using Microsoft.EntityFrameworkCore;

namespace Instient.DatabaseContext
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Customers> Customers {get;set;}
        public DbSet<Orders> Orders {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}