using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcels.Models;

namespace Parcels.Controllers
{
     public class ItemsController : Controller
     {
         [HttpPost("/calcCost")] // using http post to display the shipping cost to the user
    // ^^this line is the path in the url
    public ActionResult Item(int length,int width,int height)
    // ^^is "Item" becasuse it must match the name of the "backend" file. The parameters are the auto-implemented properties
    {
      ParcelDetails shipEstimate = new ParcelDetails( length, width, height);
      // ^^ it gets these params because it is the user input given on the form.cshtml page

      shipEstimate.CalcVolume();
      // ^is "shipEstimate" because this is the new instance of parcelDetails, therefore CalcVolume acts on this object

      shipEstimate.CalcShippingCost();
    
  
      return View("Index", shipEstimate);
      // ^^ In the View shipEstimate must be oassedin as an argumanet because the .cshtml wont know which Model were referencing without it. shipEstimate is the specific instance of the ParcelDetails class that we will interact with in our .cshtml, by calling @Model.ShippingCost.
    }
     }
}
