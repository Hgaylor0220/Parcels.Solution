using Microsoft.AspNetCore.Mvc;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")] // using get to obtain the info from the user
        public ActionResult Form() { return View(); }
        // these lines diplay the form to the user and submit the class info to the controller. gets sent to the controlller because this line occurs in the view. 
    
 
    }

  }

