using Microsoft.EntityFrameworkCore;
using NewsweatherAPI.Models;

namespace NewsweatherAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<City> City { get; set; }
    }
}