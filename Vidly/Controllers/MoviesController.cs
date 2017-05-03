using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        private readonly ShowMovieViewModel _model = new ShowMovieViewModel()
        {
            Customers =new List<Customer>
            {
                new Customer {Name = "Jhon Smith",Id = 1},
                new Customer {Name = "Alice Jhonson",Id=2}
            },
            Movies = new List<Movie>
            {
                new Movie {Name = "Matrix",Id = 1},
                new Movie {Name = "Shrek",Id = 2}
            }
        };
        
    
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Customers()
        {
            return View(_model);
        }
        
        public ActionResult Movies()
        {
            return View(_model);
        }
        [Route("Customers/Details/{id}")]
        public ActionResult Details(int? id)
        {
            return View(_model.Customers.FirstOrDefault(customer =>customer.Id==id));
        }
    }
}