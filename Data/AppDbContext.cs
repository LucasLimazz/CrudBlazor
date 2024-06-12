using CrudBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudBlazor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Users> Usuarios { get; set; } = null!;
        public DbSet<Products> Produtos { get; set; } = null!;
    }
}


