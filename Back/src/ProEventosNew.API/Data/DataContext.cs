using Microsoft.EntityFrameworkCore;
using ProEventosNew.API.Models;

namespace ProEventosNew.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Evento> Eventos { get; set; }
    }
}