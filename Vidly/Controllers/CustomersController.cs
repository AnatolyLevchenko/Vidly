using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{

    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController()
        {
            _context=new ApplicationDbContext();
        }


        public ActionResult Index()
        {
            return View(_context.Customers.Include(c => c.MembershipType).ToList());
        }
     
        
 
        public ActionResult Details(int? id)
        {
            return View(_context.Customers.Include(c=>c.MembershipType).FirstOrDefault(customer =>customer.Id==id));
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            
        }
    }
}