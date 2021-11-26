using AcmeIncWeb.Models;
using AcmeIncWeb.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeIncWeb.Controllers
{
    public class UserController : Controller
    {
        private readonly AcmeIncDbContext _context;
        UserUtil uUtil;

        public UserController(AcmeIncDbContext context)
        {
            _context = context;
            uUtil = new UserUtil(context);
        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(String email, String password)
        {

            if (uUtil.userValid(email, password))                  // checks if the user details provided are valid
            {

                HttpContext.Session.SetString("UserLoggedIn", email);   //sets the session to the user's email
                HttpContext.Session.SetInt32("UserRole", uUtil.getUserRole(email));  //adds user role as a session variable used to determine which links show in nav bar
                return RedirectToAction("Index", "Product");

            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();   //clears the session when the user logs out
            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View();
        }



        [HttpPost]
        public IActionResult CreateCustomer(User user)
        {

            user.RoleId = 101;       //sets user role to that of customer role id. 

            if (ModelState.IsValid)
            {

                if (uUtil.customerAdded(user))
                {
                    HttpContext.Session.SetString("UserLoggedIn", user.Email);                   //sets the session to the user's email
                    HttpContext.Session.SetInt32("UserRole", uUtil.getUserRole(user.Email));      //adds user role as a session variable used to determine which links show in nav bar
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ViewBag.Error = "User already exists.";                      //error message when there is a duplicate user
                }
            }
            else
            {

                Console.WriteLine("Not valid user");
                return View();
            }

            return View();
        }

        [HttpGet]
        public IActionResult CreateEmployee()
        {

            ViewData["Roles"] = getListRoles();          //sets the list of roles to be shown to the admin 

            return View();
        }

        [HttpPost]
        public IActionResult CreateEmployee(User user, String RoleType)
        {

            int roleId = Convert.ToInt32(RoleType);      //sets the user's role type to the values passed in
            user.RoleId = roleId;

            if (ModelState.IsValid)
            {

                if (uUtil.customerAdded(user))
                {
                    HttpContext.Session.SetString("UserLoggedIn", user.Email);     //sets the session to the user's email
                    HttpContext.Session.SetInt32("UserRole", uUtil.getUserRole(user.Email));     //adds user role as a session variable used to determine which links show in nav bar
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ViewBag.Error = "User already exists.";
                }
            }
            
            ViewData["Roles"] = getListRoles();   //sets the list of roles to be displayed to the user
            return View();

        }

        public List<SelectListItem> getListRoles()             //gets a list ofselect items based off the roles in db
        {
            List<SelectListItem> roleItems = new List<SelectListItem>();
            List<Role> roles = uUtil.getRoles();

            foreach (Role role in roles)
            {
                if (!role.Type.Equals("Customer"))
                {
                    roleItems.Add(new SelectListItem { Value = role.RoleId + "", Text = role.Type }); //removes the customer role 
                }

            }

            return roleItems;
        }

        public IActionResult UserHistory()
        {

           List<Order> orders = uUtil.getUserOrders(HttpContext.Session.GetString("UserLoggedIn"));   //gets list oforders for the user logged in

           return View(orders);

        }


    }
}
