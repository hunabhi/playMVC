using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoLib.Models;


namespace VideoLib.Controllers
{
    public class MoviesController : Controller
    {
        
        public ActionResult Random()// Good practise to change ActionResult to ViewResult so its easy to unit test later save an extra cast
        {
            // GET: Movies/Randomx
            var movie = new Movie() { Name = "Shrek!" };
            
            //return View(movie);// view is a helper method inherited from the base controller class
            return Content("Hello World!");
            
            //return new ViewResult(); // but above approach is more common is accpeted
            //PartialViewResult
            //ContentResult
            //RedirectResult();
            //RedirectToRouteResult();
            //JsonResult();
            //FileResult();
            //HttpNotFoundResult();
            //EmptyResult();

        }
    }
}