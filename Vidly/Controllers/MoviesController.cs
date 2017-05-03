using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        
        public ActionResult Random()
        {
            Movie movie=new Movie() {Name = "Shrek"};

            return View(movie);
        }
        [Route("movies/release/{year}/{month:regex(\\d2):range(1,12)}")]
        public ActionResult ByReleaseDate(int year,int month)
        {

            return Content(year + "/" + month);
        }
    }
}