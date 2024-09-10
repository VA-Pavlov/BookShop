namespace BookShop.Models
{
    public class Product
    {
        private static int countProduct = 0;
        public int Id{ get;}
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Description { get; set; }
        public Product()
        {
            Id = countProduct++;
        }
        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Cost}\n{Description}\n";
        }
    }
}
