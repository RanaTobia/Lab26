using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoffeeShopLab23.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using System.Web;
using Umbraco.Forms.Core.Models;
using System.Text.Json;

namespace CoffeeShopLab23.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<Items> itemlist;
        private List<Users> userlist;
        private ShopDbContext db;

        private static List<UserItem> userItems = new List<UserItem>(); // will store user cart details


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // make a session object
            //HttpContext.Session.SetString("TempKey" , "Hello World");


            //use get string to retrieve the data in the session 
            //var testSession = HttpContext.Session.GetString("TempKey");

            return View();
        }
        //public IActionResult login(string users)
        //{
        //    ShopDBContext db = new ShopDBContext();

        //    foreach (Users u in db.Users)
        //    {
        //        if (users == u.UserName)
        //        {
        //            return View();
        //        }
        //       else  return View("Register");
        //    }
        //    return View("Shop");
        //}

        public IActionResult ValidateUser(Users user)
        {
            ShopDbContext db = new ShopDbContext();

            Users dbUser = (from u in db.Users
                           where u.UserName.Equals(user.UserName) &&
                                 u.Password.Equals(user.Password)
                           select u).FirstOrDefault();


            //var users1 = db.Users.Where(i => i.UserName.Equals(user.UserName));
            //var users2 = users1.Where(i => i.Password.Equals(user.Password));

            //if (users1 == user && users2 == user)
            //{
            //    HttpContext.Session.SetInt32("current", users.Id);
            //    TempData["isUserLogin"] = true;
            //    return View("shop");
            //}
            //if (users2 == null)
            //{
            //    ViewBag.Message = "Please type your email";

            //    return View("Login");
            //    // Password invalid.
            //}
            if(dbUser != null)
            {
                HttpContext.Session.SetInt32("current", dbUser.Id);
                TempData["isUserLogin"] = true;
                return View("shop", db);
            }
            else if (dbUser == null)
            {
                TempData["IncorrectUserName or password"] = true;
                return View("Login");
            }

            else
            {
                // invalid user
                TempData["IncorrectUserName or password"] = true;
                return View("Login");
            }


        }
        public IActionResult login()
        {
            //set a TempData with true when they login
            //TempData["isUserLogin"] = true;
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
       
        public IActionResult Buy(int Quantity, string Name, int Id, string Description, decimal Price, Users users)
        {
            ShopDbContext db = new ShopDbContext();
            var tempItemList = db.Items.ToList();
            var tempUserList = db.Users.ToList();
            var UserID = HttpContext.Session.GetInt32("current");

            foreach (Users u in db.Users)

            {
                if (u.Id == UserID)
                    ViewBag.Founds = u.Funds;
                    ViewBag.UserName = u.UserName;
            }

            //foreach (var items in tempItemList)
            //{
            //    //find the item and update the table to reflect 
            //    //subtracting from that items quantity

            //}
            foreach (Items it in db.Items)
            {
                if (it.Id == Id)
                    ViewBag.ItemQuantity = it.Quantity;
            
            }

            ViewBag.Quantity = Quantity;
            ViewBag.Name = Name;
            ViewBag.Id = Id;
            ViewBag.Price = Price;
            

            // add item to the list

            //UserItem item = new UserItem();
            //item.ItemId = Id;


            //item.UserId = Convert.ToInt32(HttpContext.Session.GetString("userName"));



            // add item to list

            //userItems.Add(item);

            //decimal total = Price * Quantity;
            //if (total > ShopDBContext)

            return View();

        }


        public IActionResult BuyItem()
        {
            return View();
        }

        public IActionResult Shop(Users users)
        {
            ShopDbContext db = new ShopDbContext();
            //HttpContext.Session.SetString("userName", userName);
            HttpContext.Session.SetInt32("current",users.Id);
            //if this is null, they skipped login to view the shop without logging in
            if (TempData["isUserLogin"] == null)
            {
                TempData["isUserLogin"] = false;
            }

            return View(db);
        }

        // add the new user after the registration 
        public IActionResult MakeNewUser(Users u)
        {
            ShopDbContext db = new ShopDbContext();

            db.Users.Add(new Models.Users()
            {
                UserName = u.UserName,
                Email = u.Email,
                Password = u.Password,
                Gender = u.Gender,
                PhoneNumber = u.PhoneNumber,
                DateOfBirth = u.DateOfBirth,
                Counrty = u.Counrty,
            });

            // we should save changes that we just made to our database 
            db.SaveChanges();
            return View("Login");
        }


        public IActionResult Get(string Items)
        {
            var itemObj = new Items();
            ShopDbContext db = new ShopDbContext();
            foreach (Items items in db.Items)
            {
                itemObj = new Items()
                {
                    Id = items.Id,
                    Name = items.Name,
                    Description = items.Description,
                    Price = items.Price,
                    Quantity = items.Quantity,

                };
            }


            return Ok(itemObj);
        }

        public IActionResult Privacy()
        {
            var user = User.Identity;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Review()
        {
            return View();
        }
    }


}
