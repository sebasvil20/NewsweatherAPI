using Microsoft.EntityFrameworkCore;
using NewsweatherAPI.Models;

namespace NewsweatherAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Weather> Weather { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<SearchHistory> SearchHistory { get; set; }
        
    }
    
}