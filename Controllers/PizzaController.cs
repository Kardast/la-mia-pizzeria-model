using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            PizzeriaDbContext db = new PizzeriaDbContext();

            List<Pizza> listPizza = db.Pizzas.ToList();

            //qualche altra cosa...

            return View(listPizza);
        }

        //public IActionResult Detail(int id)
        //{

        //    BlogDbContext db = new BlogDbContext();

        //    Post post = db.Posts.Where(p => p.Id == id).FirstOrDefault();

        //    return View(post);
        //}
    }
}
