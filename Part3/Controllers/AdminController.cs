using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Part3.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Part3.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly KhumaloCraftContext _context;

        public AdminController(KhumaloCraftContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var orders = await _context.Orders
                .Include(o => o.Product)
                .Include(o => o.User)
                .ToListAsync();

            return View(orders);
        }
    }
}
