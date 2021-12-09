using System.Collections.Generic;
using System.Linq;
using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //var data = _context.Actors.ToList();
            var data = GetActors();
            return View(data);
        }

        IList<Actor> GetActors()
        {
            return new List<Actor>()
            {
                new Actor()
                {
                    FullName = "Actor 1",
                    Bio = "This is the Bio of the first actor",
                    ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                },
                new Actor()
                {
                    FullName = "Actor 2",
                    Bio = "This is the Bio of the second actor",
                    ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                },
                new Actor()
                {
                    FullName = "Actor 3",
                    Bio = "This is the Bio of the second actor",
                    ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                },
                new Actor()
                {
                    FullName = "Actor 4",
                    Bio = "This is the Bio of the second actor",
                    ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                },
                new Actor()
                {
                    FullName = "Actor 5",
                    Bio = "This is the Bio of the second actor",
                    ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                }
            };
        }
    }
}
