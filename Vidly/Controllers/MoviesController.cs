using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context=new ApplicationDbContext();
        }
        // GET: Movies
        
        public ActionResult Index()
        {
            return View(_context.Movies.Include(c=>c.Genre));
        }
        
        public ActionResult Details(int? id)
        {
            if (id == null)
                return HttpNotFound();
            return View(_context.Movies.Include(c=>c.Genre).Single(movie => movie.Id==id));
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}