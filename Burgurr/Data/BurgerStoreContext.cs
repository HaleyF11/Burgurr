using Microsoft.EntityFrameworkCore;


namespace Burgurr.Data
{
    public class BurgerStoreContext : DbContext
    {
        public BurgerStoreContext(DbContextOptions options) : base(options) {}

        public DbSet<Burger> Pizzas { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuring a many-to-many special -> topping relationship that is friendly for serialization
            modelBuilder.Entity<BurgerIngredient>().HasKey(pst => new { pst.BurgerId, pst.IngredientId });
            modelBuilder.Entity<BurgerIngredient>().HasOne<Burger>().WithMany(ps => ps.Ingredients);
            modelBuilder.Entity<BurgerIngredient>().HasOne(pst => pst.Ingredient).WithMany();
        }
    }
}
