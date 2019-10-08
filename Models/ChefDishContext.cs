using Microsoft.EntityFrameworkCore;

namespace chefsdishes.Models
{
    // Create our DB connection
    public class ChefDishContext : DbContext
    {
        public ChefDishContext(DbContextOptions<ChefDishContext> options) : base(options) { }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Dish> Dishes { get; set; }
    }
}