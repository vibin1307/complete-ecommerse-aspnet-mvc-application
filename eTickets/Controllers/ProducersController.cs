using System.Collections.Generic;
using System.Threading.Tasks;
using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //var data = await _context.Producers.ToListAsync();
            var data = GetProducers();
            return View(data);
        }

        private List<Producer> GetProducers()
        {
            return new List<Producer>()
            {
                new Producer()
                {
                    FullName = "Producer 1",
                    Bio = "This is the Bio of the first actor",
                    ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                },
                new Producer()
                {
                    FullName = "Producer 2",
                    Bio = "This is the Bio of the second actor",
                    ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                },
                new Producer()
                {
                    FullName = "Producer 3",
                    Bio = "This is the Bio of the second actor",
                    ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                },
                new Producer()
                {
                    FullName = "Producer 4",
                    Bio = "This is the Bio of the second actor",
                    ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                },
                new Producer()
                {
                    FullName = "Producer 5",
                    Bio = "This is the Bio of the second actor",
                    ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                }
            };
        }
    }
}
