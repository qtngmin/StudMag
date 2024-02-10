using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;
using StudMag.Data;
using StudMag.Models;

namespace StudMag.Controllers
{
    public class ClubController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ClubController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var clubs = _context.Clubs.ToList();
            return View(clubs);
        }
        public IActionResult Detail(int id)
        {
            Club club = _context.Clubs.FirstOrDefault(c => c.Id == id);
            return View(club);
        }
    }
}