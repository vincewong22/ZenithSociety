using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ZenithWebSite.Data;
using ZenithWebSite.Models;

namespace ZenithWebSite.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private ApplicationUser _user;

        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        private async Task getUser()
        {
            _user = await _userManager.GetUserAsync(HttpContext.User);
        }

        private List<Event> getWeekEvents(DateTime date)
        {
            DateTime start = date.Date.AddDays(-(int)date.DayOfWeek + 1);
            DateTime end = start.AddDays(7);
            var events = _context.Events.Where(e => e.EventFromDate >= start
            & e.EventFromDate < end).ToList();
            Task q = getUser();
            q.Wait();

            if (_user?.Id == null)
            {
                events.RemoveAll(e => e.IsActive == false);
            }

            return events;
        }

        private IEnumerable<Event> getActivities(List<Event> list)
        {
            foreach (var e in list)
            {
                e.Activity = _context.Activities.FirstOrDefault(a => a.ActivityId == e.ActivityId);
            }
            return list;
        }

        public async Task<ActionResult> Index()
        {
            return View(getActivities(getWeekEvents(DateTime.Today)));
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
