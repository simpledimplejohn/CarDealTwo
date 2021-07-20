using System;
using System.Collections.Generic;

namespace CarDealership.Models 
{

  public class Cars
  {
    // public string MakeModel {get; set; }// new- erika
    private static string _makeModel;
    private static int _price;
    private static int _miles;

    public Cars(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    public static List<Cars> CarList { get; set; } = new List<Cars>() {  };    

    public string GetMakeModel()// The naming convention for a getter method is Get followed by the field name: GetNameOfProperty().
    {
      return _makeModel;
    }

    public static int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price <= maxPrice);
    }
  }

}



// namespace Dealership.Models
// {
//   public class Item // definition of what a thing will have (is our constructor) (is our object)
//   {
//     public string Description { get; set; } // object property 
//     private static List<Item> _instances = new List<Item> {}; 

//     public Item(string description)  // method 
//     {
//       Description = description;
//       _instances.Add(this);
//     }
//     public static List<Item> GetAll() //a list function called GetAll()
//     {
//       return _instances;
//     }

//     public static void ClearAll()
//     {
//     _instances.Clear();
//     }
//   }
// }