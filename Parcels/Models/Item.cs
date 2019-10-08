using System.Collections.Generic;
using System;
// this file contains the backend

namespace Parcels.Models
{
  public class Parcels
  // class and namespace have same name
  {
    public int ParcelLength { get; set; }
    public int ParcelWidth { get; set; }
    public int ParcelHeight { get; set; }
    public int ParcelVolume { get; set; }
    public int ShippingCost { get; set; }






  }
}






//     private static List<Item> _instances = new List<Item> { };

//     public Item(string description)
//     {
//       Description = description;
//       _instances.Add(this);
//     }

//     public static List<Item> GetAll()
//     {
//       return _instances;
//     }

//     public static void ClearAll()
//     {
//       _instances.Clear();
//     }