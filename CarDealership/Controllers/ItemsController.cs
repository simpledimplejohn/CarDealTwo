// The home controller is the spot where? 
// where all the routes are contained for the Items
// set get or post


using Microsoft.AspNetCore.Mvc;
using Dealership.Models; //import the Class here
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/cars")] //this is the path
    public ActionResult Index() // method that does the getting
    {
      List<Item> allCars = Cars.GetAll(); //pull the class here and put it into a list--why list??
      return View(allCars);
    }
    
    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")] //this is the posted item
    public ActionResult Create(string description) //
    {
      Cars myCar = new Cars(description);
      return RedirectToAction("Index");
    }
  }
}

// look here for error