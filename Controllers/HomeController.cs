using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WedProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace WedProj.Controllers
{
    public class HomeController : Controller
    {
        private WedContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(WedContext context)
        {
            dbContext = context;
        }
        [HttpGet("")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("/regProcess")]
        public IActionResult AddToDb(RegUser newUser)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email","Email already in use");
                    return View("Register");
                }
                else 
                {
                    PasswordHasher<RegUser> Hasher = new PasswordHasher<RegUser>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    dbContext.Add(newUser);
                    
                    dbContext.SaveChanges();
                    HttpContext.Session.SetInt32("UserId",newUser.UserId);
                    return RedirectToAction("Dashboard");
                }

            }
            else
            {
                return View("Register");
            }
        }

        [HttpGet("/login")]
        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost("/logProcess")]
        public IActionResult LogProcess(LogUser auser)
        {
            Console.WriteLine("********Inside Log Process********************");
            
            if (ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == auser.LogEmail);
                if (userInDb == null)
                {
                    ModelState.AddModelError("LogEmail","This email does not exist");
                    return View("LoginPage");
                    
                }
                else
                {
                    var hasher = new PasswordHasher<LogUser>();
                    var result = hasher.VerifyHashedPassword(auser,userInDb.Password,auser.LogPassword);
                    if (result==0)
                    {
                        ModelState.AddModelError("LogPassword","Invalid Password");
                        return View("LoginPage");
                    }
                    else
                    {
                        HttpContext.Session.SetInt32("UserId",userInDb.UserId);
                        return RedirectToAction("Dashboard");
                    }
                    
                }

            }
            else
            {
                return View("LoginPage");

            }

        }
        [HttpGet("/dashboard")]
        public IActionResult Dashboard()
        {
            List<Wedding> AllWed = dbContext.Weddings.Include(w => w.Guests).ToList();
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            Console.WriteLine(ViewBag.UserId);
            return View(AllWed);
        }

        [HttpGet("/create")]
        public IActionResult CreateWedding()
        {
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            return View();
        }

        [HttpPost("/addEvent")]
        public IActionResult WedToDb(Wedding newWed)
        {
            if(ModelState.IsValid)
            {
                if (newWed.WeddingDate < DateTime.Now)
                {
                    Console.WriteLine("*************Inside Error Wedding Date***********");
                    ModelState.AddModelError("WeddingDate","Wedding Date Cannot be from the past");
                    return View("CreateWedding");
                }
                dbContext.Weddings.Add(newWed);
                
                dbContext.SaveChanges();
                
                return RedirectToAction("ShowEvent",new{wid = newWed.WedId});
            }
            return View("CreateWedding");
        }

        [HttpGet("/show/{wid}")]
        public IActionResult ShowEvent(int wid)
        {
            Wedding show = dbContext.Weddings.FirstOrDefault(w => w.WedId == wid);
            return View(show);

        }

        [HttpGet("/rsvp/{wId}")]
        public IActionResult RSVP(int wId)
        {


            Wedding awed = dbContext.Weddings
            .Include(g => g.Guests)
            .ThenInclude(u => u.Person)
            .FirstOrDefault(w => w.WedId == wId);
            RegUser auser = dbContext.Users
            .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            Console.WriteLine("*********************");
            Console.WriteLine(awed.WedId);
            Console.WriteLine(auser.UserId);
            Assoc newGuest = new Assoc
            {
                UId = auser.UserId,
                WId = awed.WedId,
                Person = auser,
                Event = awed
            };

            awed.Guests.Add(newGuest);
            dbContext.SaveChanges();

            Console.WriteLine("******************Guest Added************");
            return RedirectToAction("Dashboard");
        }

        [HttpGet("/unrsvp/{wId}")]
        public IActionResult UNRSVP(int wId)
        {
            
            Console.WriteLine("***************Inside  Unrsvp************ ");
            Wedding awed = dbContext.Weddings
            .Include(g => g.Guests)
            .ThenInclude(u => u.Person)
            .FirstOrDefault(w => w.WedId == wId);
            Console.WriteLine(awed.WedId);
            RegUser auser = dbContext.Users
            .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            System.Console.WriteLine(auser.UserId);
            System.Console.WriteLine("####################### user id");
            Assoc anassoc = dbContext.Assocs.Where(u => u.UId == auser.UserId && u.WId == awed.WedId).FirstOrDefault();
            System.Console.WriteLine(anassoc);
            System.Console.WriteLine(anassoc.AssocId);
            dbContext.Assocs.Remove(anassoc);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("/deleteEvent/{wid}")]
        public IActionResult Delete(int wId)
        {
            Wedding awed = dbContext.Weddings
            .Include(g => g.Guests)
            .ThenInclude(u => u.Person)
            .FirstOrDefault(w => w.WedId == wId);
            dbContext.Weddings.Remove(awed);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }


        [HttpGet("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Register");
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
    }
}
