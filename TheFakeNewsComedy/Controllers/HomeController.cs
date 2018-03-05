using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheFakeNewsComedy.Models;

namespace TheFakeNewsComedy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //using (Repository.CategoryRepository repo = new Repository.CategoryRepository())
            //{
            //    Repository.Category cat = new Repository.Category();
            //    cat.Name = "Test1";

            //    cat.Id = repo.SaveCategory(cat);

            //    var model = repo.GetSavedCategory(cat.Id);
            //}
            return View();
        }

        public IActionResult Articles()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
