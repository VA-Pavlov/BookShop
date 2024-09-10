using BookShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookShop.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return BooksRepository.GetProducts();
        }
    }
}
