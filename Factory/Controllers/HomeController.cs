using System.Linq;
using Factory.Models;
using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {

      private readonly FactoryContext _db;

      public HomeController(FactoryContext db)
      {
          _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        ListAllViewModel model = new ListAllViewModel();
        model.Engineers = _db.Engineers.ToList();
        model.Machines = _db.Machines.ToList();
        return View(model);
      }

    }
}