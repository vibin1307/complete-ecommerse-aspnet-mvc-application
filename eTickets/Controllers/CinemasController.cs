using System.Collections.Generic;
using System.Threading.Tasks;
using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;

        public CinemasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //var allCinemas = _context.Cinemas.ToListAsync();
            var cinemas = GetCinemas();
            return View(cinemas);
        }

        private IList<Cinema> GetCinemas()
        {
            return new List<Cinema>()
            {
                new Cinema()
                {
                    Name = "Cinema 1",
                    Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                    Description = "This is the description of the first cinema"
                },
                new Cinema()
                {
                    Name = "Cinema 2",
                    Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                    Description = "This is the description of the first cinema"
                },
                new Cinema()
                {
                    Name = "Cinema 3",
                    Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                    Description = "This is the description of the first cinema"
                },
                new Cinema()
                {
                    Name = "Cinema 4",
                    Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                    Description = "This is the description of the first cinema"
                },
                new Cinema()
                {
                    Name = "Cinema 5",
                    Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                    Description = "This is the description of the first cinema"
                },
            };
        }
    }
}
