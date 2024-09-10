using BookShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    public class ProductController : Controller
    {
        public string Index(int id)
        {
            return BooksRepository.Products[id].ToString();
        }
    }
}
