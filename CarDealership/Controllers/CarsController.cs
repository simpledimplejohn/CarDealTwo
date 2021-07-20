// The home controller is the spot where? 
// where all the routes are contained for the Items
// set get or post


using Microsoft.AspNetCore.Mvc;
using CarDealership.Models; //import the Class here
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")] //this is the path
    public ActionResult Index() // method that does the getting
    {
      Cars volkswagen = new Cars("1974 Volkswagen Thing", 1100, 368792);
      Cars yugo = new Cars("1980 Yugo Koral", 700, 56000);
      Cars ford = new Cars("1988 Ford Country Squire", 1400, 239001);
      Cars amc = new Cars("1976 AMC Pacer", 400, 198000);
      
      //List<int> allCars = Cars.GetPrice(); //pull the class here and put it into a list--why list??
      List<Cars> carList = Cars.CarList;
      carList.Add(volkswagen);
      carList.Add(yugo);
      carList.Add(ford);
      carList.Add(amc);
      // Cars.GetMakeModel();
      return View(carList);

    }
    
    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    // [HttpPost("/cars")] //this is the posted item
    // public ActionResult Create(string description) //
    // {
    //   Cars myCar = new Cars(description);
    //   return RedirectToAction("Index");
    // }
  }
}

// look here for error