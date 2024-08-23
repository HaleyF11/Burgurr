namespace Burgurr.Data
{
    public class SeedData
    {
        public static void Initialize(BurgerStoreContext db)
        {
            var burgers = new Burger[]
            {
                new Burger()
                {
                    Id = 1,
                    Name = "Hamburger",
                    Description = "A normal hamburger, plain and simple.",
                    BasePrice = 6.99m
                },               
                new Burger()
                {   
                    Id = 2,
                    Name = "Cheeseburger",
                    Description = "Cheesy goodness.",
                    BasePrice = 8.99m
                },                
                new Burger()
                {
                    Id = 3,
                    Name = "Chicken Burger",
                    Description = "Chimken delight.",
                    BasePrice = 7.99m
                },                
                new Burger()
                {
                    Id = 4,
                    Name = "Double Cheeseburger",
                    Description = "Double cheesy goodness.",
                    BasePrice = 10.99m
                },
            };
        }
    }
}
