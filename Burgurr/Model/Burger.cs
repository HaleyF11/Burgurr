namespace Burgurr
{
    public class Burger
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public int OrderId { get; set; }

        public List<BurgerIngredient> Ingredients { get; set; }
    }
}
