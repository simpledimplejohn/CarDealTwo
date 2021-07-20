using System;
using System.Collections.Generic;

namespace Dealership.Models 
{

  public class Cars
  {
    private string _makeModel;
    private int _price;
    private int _miles;

    public Cars(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    private static Cars volkswagen = new Cars("1974 Volkswagen Thing", 1100, 368792);
    private static Cars yugo = new Cars("1980 Yugo Koral", 700, 56000);
    private static Cars ford = new Cars("1988 Ford Country Squire", 1400, 239001);
    private static Cars amc = new Cars("1976 AMC Pacer", 400, 198000);
    public List<Cars> CarList = new List<Cars>() { volkswagen, yugo, ford, amc };

    

    public string GetMakeModel()// The naming convention for a getter method is Get followed by the field name: GetNameOfProperty().
    {
      return _makeModel;
    }

    public int GetPrice()
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