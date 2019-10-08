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
   
  public ParcelDetails(int length, int width , int height)
  // The parameters here correspond with the form, it is representative of the user input, but that input is actually passed to the controller where the ParcelDetails object is instantiated. This exists so that when the ParcelDetail object is instantiated it will posess these properties.
  {
    ParcelLength = length;
    ParcelHeight = height;
    ParcelWidth = width;
    // This is our constructor. Every parcel will have these properties. 
  }

  
    public int CalcVolume()
    {
      ParcelVolume = ParcelLength * ParcelWidth * ParcelHeight;
      return ParcelVolume;
    }

    public int CalcShippingCost()
    {
      ShippingCost = ParcelVolume * 3;
      return ShippingCost;
    }

  }
}




