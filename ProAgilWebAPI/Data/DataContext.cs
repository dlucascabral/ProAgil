using Microsoft.EntityFrameworkCore;
using ProAgilWebAPI.Model;

namespace ProAgilWebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Evento> Eventos { get; set; }
    }
}