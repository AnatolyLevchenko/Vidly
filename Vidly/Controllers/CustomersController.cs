using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context=new ApplicationDbContext();
        }
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
            return View(_context.Customers.Include(c=>c.MembershipType).ToList());
        }
        
        public ActionResult Movies()
        {
            return View(_model);
        }
        [Route("Customers/Details/{id}")]
        public ActionResult Details(int? id)
        {
            return View(_context.Customers.FirstOrDefault(customer =>customer.Id==id));
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            
        }
    }
}