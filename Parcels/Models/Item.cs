using System.Collections.Generic;
using System;
// this file contains the backend

namespace Parcels.Models
{
  public class ParcelDetails
  // class and namespace have different name
  {
    public int ParcelLength { get; set; }
    public int ParcelWidth { get; set; }
    public int ParcelHeight { get; set; }
    public int ParcelVolume { get; set; }
    public int ShippingCost { get; set; }


    public int CalcVolume(int ParcelLength, int ParcelWidth, int ParcelHeight)
    {
      int ParcelVolume = ParcelLength * ParcelWidth * ParcelLength;
      return ParcelVolume;
    }

    public int CalcShippingCost(int ParcelVolume)
    {
      int ShippingCost = ParcelVolume * 3;
      return ShippingCost;
    }

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