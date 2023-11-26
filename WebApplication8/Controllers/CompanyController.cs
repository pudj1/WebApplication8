using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using WebApplication8.Data;

    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CompanyController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var companies = _context.Company.ToList();
            return View(companies);
        }
    }
}
