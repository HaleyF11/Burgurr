namespace Burgurr
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string GetFormattedPrice() => Price.ToString();
    }
}
