using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithWebSite.Data;

namespace ZenithWebSite.Models
{
    public class SeedData
    {
        public async static void Initialize(IServiceProvider serviceProvider, ApplicationDbContext db)
        {
            await AddRoles(serviceProvider);
            await AddUsers(serviceProvider);
            AddActivities(db);
            AddEvents(db);
        }

        public static void AddActivities(ApplicationDbContext _db)
        {
            if (!_db.Activities.Any())
            {
                IList<Activity> activities = new List<Activity>();

                activities.Add(new Activity { ActivityDescription = "Go-Karting", CreationDate = new DateTime(2003, 01, 04) });
                activities.Add(new Activity { ActivityDescription = "Super Smash Bros Melee Tournament", CreationDate = new DateTime(2001, 11, 21) });
                activities.Add(new Activity { ActivityDescription = "Tennis", CreationDate = new DateTime(1990, 03, 12) });
                activities.Add(new Activity { ActivityDescription = "Polo", CreationDate = new DateTime(1976, 12, 12) });
                activities.Add(new Activity { ActivityDescription = "Water Polo", CreationDate = new DateTime(2002, 04, 28) });
                activities.Add(new Activity { ActivityDescription = "Competitive Vaping", CreationDate = new DateTime(2015, 10, 29) });

                foreach (Activity act in activities)
                {
                    _db.Add(act);
                }

                _db.SaveChanges();
            }
        }

        public static void AddEvents(ApplicationDbContext _db)
        {
            if (!_db.Events.Any())
            {
                IList<Event> events = new List<Event>();
                events.Add(new Event
                {
                    EventFromDate = new DateTime(2017, 03, 20, 13, 0, 0),
                    EventToDate = new DateTime(2017, 03, 20, 20, 30, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Tennis").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Tennis").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 03, 18),
                    IsActive = true
                });

                events.Add(new Event
                {
                    EventFromDate = new DateTime(2017, 03, 21, 13, 0, 0),
                    EventToDate = new DateTime(2017, 03, 21, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Go-Karting").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Go-Karting").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 03, 18),
                    IsActive = true
                });

                events.Add(new Event
                {
                    EventFromDate = new DateTime(2017, 03, 22, 14, 0, 0),
                    EventToDate = new DateTime(2017, 03, 23, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Super Smash Bros Melee Tournament").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Super Smash Bros Melee Tournament").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 03, 18),
                    IsActive = true
                });

                events.Add(new Event
                {
                    EventFromDate = new DateTime(2017, 03, 24, 14, 0, 0),
                    EventToDate = new DateTime(2017, 03, 24, 16, 30, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 03, 18),
                    IsActive = true
                });

                events.Add(new Event
                {
                    EventFromDate = new DateTime(2017, 03, 27, 13, 0, 0),
                    EventToDate = new DateTime(2017, 03, 27, 20, 30, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Tennis").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Tennis").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 03, 26),
                    IsActive = true
                });

                events.Add(new Event
                {
                    EventFromDate = new DateTime(2017, 03, 28, 13, 0, 0),
                    EventToDate = new DateTime(2017, 03, 28, 20, 30, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Polo").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Polo").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 03, 26),
                    IsActive = true
                });

                events.Add(new Event
                {
                    EventFromDate = new DateTime(2017, 03, 30, 13, 0, 0),
                    EventToDate = new DateTime(2017, 04, 30, 20, 30, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Water Polo").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Water Polo").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 03, 26),
                    IsActive = true
                });

                events.Add(new Event
                {
                    EventFromDate = new DateTime(2017, 03, 31, 14, 0, 0),
                    EventToDate = new DateTime(2017, 03, 31, 16, 30, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 03, 26),
                    IsActive = true
                });

                events.Add(new Event
                {
                    EventFromDate = new DateTime(2017, 04, 3, 13, 0, 0),
                    EventToDate = new DateTime(2017, 04, 3, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Go-Karting").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Go-Karting").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 04, 1),
                    IsActive = true
                });

                events.Add(new Event
                {
                    EventFromDate = new DateTime(2017, 04, 4, 14, 0, 0),
                    EventToDate = new DateTime(2017, 04, 6, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Super Smash Bros Melee Tournament").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Super Smash Bros Melee Tournament").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 04, 1),
                    IsActive = true
                });

                events.Add(new Event
                {
                    EventFromDate = new DateTime(2017, 04, 5, 13, 0, 0),
                    EventToDate = new DateTime(2017, 04, 5, 20, 30, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Tennis").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Tennis").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 04, 1),
                    IsActive = true
                });

                events.Add(new Event
                {
                    EventFromDate = new DateTime(2017, 04, 7, 14, 0, 0),
                    EventToDate = new DateTime(2017, 04, 7, 16, 30, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 04, 1),
                    IsActive = true
                });

                events.Add(new Event
                {
                    EventFromDate = new DateTime(2017, 04, 10, 13, 0, 0),
                    EventToDate = new DateTime(2017, 04, 10, 20, 30, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Polo").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Polo").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 04, 8),
                    IsActive = true
                });

                events.Add(new Event
                {
                    EventFromDate = new DateTime(2017, 04, 10, 13, 0, 0),
                    EventToDate = new DateTime(2017, 04, 10, 20, 30, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Water Polo").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Water Polo").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 04, 8),
                    IsActive = true
                });

                events.Add(new Event
                {
                    EventFromDate = new DateTime(2017, 04, 12, 13, 0, 0),
                    EventToDate = new DateTime(2017, 04, 12, 20, 30, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Tennis").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Tennis").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 04, 8),
                    IsActive = true
                });

                events.Add(new Event
                {
                    EventFromDate = new DateTime(2017, 04, 13, 13, 0, 0),
                    EventToDate = new DateTime(2017, 04, 13, 18, 0, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Go-Karting").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Go-Karting").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 04, 8),
                    IsActive = true
                });

                events.Add(new Event
                {
                    EventFromDate = new DateTime(2017, 04, 14, 14, 0, 0),
                    EventToDate = new DateTime(2017, 04, 14, 16, 30, 0),
                    EnteredByUsername = "a",
                    ActivityId = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault().ActivityId,
                    Activity = _db.Activities.Where(x => x.ActivityDescription == "Competitive Vaping").FirstOrDefault(),
                    CreationDate = new DateTime(2017, 04, 8),
                    IsActive = true
                });

                foreach (Event eve in events)
                {
                    _db.Add(eve);
                }

                _db.SaveChanges();
            }
        }

        public static async Task AddRoles(IServiceProvider serviceProvider)
        {
            var _db = serviceProvider.GetService<ApplicationDbContext>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            //var roleStore = new RoleStore<IdentityRole>(_db);


            string[] roles = new string[] { "Member", "Admin" };

            foreach (string role in roles)
            {
                /*if  (!_db.Roles.Any(r => r.Name == role)) {
                    _db.Add(new IdentityRole(role));
                }*/
                if (!_db.Roles.Any(r => r.Name == role))
                {
                    //_db.Add(new IdentityRole(role));
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            //_db.SaveChanges();
        }

        public static async Task AddUsers(IServiceProvider serviceProvider)
        {
            var _db = serviceProvider.GetService<ApplicationDbContext>();
            var _userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();

            ApplicationUser admin = new ApplicationUser() { Email = "a@a.a", UserName = "a", FirstName = "a", LastName = "a" };
            ApplicationUser member = new ApplicationUser() { Email = "m@m.m", UserName = "m", FirstName = "m", LastName = "m" };

            await _userManager.CreateAsync(admin, "P@$$w0rd");
            await _userManager.CreateAsync(member, "P@$$w0rd");
            _db.SaveChanges();

            await _userManager.AddToRoleAsync(_db.Users.Where(u => u.UserName == "a").FirstOrDefault(), "Admin");
            await _userManager.AddToRoleAsync(_db.Users.Where(u => u.UserName == "a").FirstOrDefault(), "Member");
            await _userManager.AddToRoleAsync(_db.Users.Where(u => u.UserName == "m").FirstOrDefault(), "Member");
            _db.SaveChanges();
        }
    }
}
