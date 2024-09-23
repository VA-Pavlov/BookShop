namespace BookShop.Models
{
    public static class BooksRepository
    {
        public static List<Product> Products = new List<Product>() {
        new Product(){Name = "Преступление и наказание", Cost=450, Description="sdfdf"},
        new Product(){Name = "Война и мир", Cost=500, Description="sdfdf"}
        };
        public static string GetProducts()
        {
            return string.Join("\n", Products);
        }
    }
}
