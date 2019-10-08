using Microsoft.AspNetCore.Mvc;
using Parcels.Models;


namespace Parcels.Controllers
{
  public class HomeController : Controller
  {
        [Route("/")]
        public ActionResult Form() { return View(); }
        // these lines diplay the form to the user and submit the class info to the controller. gets sent to the controlller because this line occurs in the view. 
    

    [Route("/calcCost")]
    // ^^this line is the path in the url
    public ActionResult Item(int ParcelLength, int ParcelWidth, int ParcelHeight, int ParcelVolume, int ShippingCost)
    // ^^is "Item" becasuse it must match the name of the "backend" file. The parameters are the auto-implemented properties
    {
      ParcelDetails shipEstimate = new ParcelDetails();
  

      return View(ShippingCost);
    }

    }

  }

