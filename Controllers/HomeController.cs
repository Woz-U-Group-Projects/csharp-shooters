using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValkyrieIMS.Models;
using Microsoft.EntityFrameworkCore;
using SecFromScratch.Models;

namespace ValkyrieIMS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User user) {
            if (ModelState.IsValid) {

                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Welcome));
            }
            return View(user);
        }

        public IActionResult Welcome() {
            return View();
        }

        public ViewResult Login() {
            return View();
        }


    }
}
