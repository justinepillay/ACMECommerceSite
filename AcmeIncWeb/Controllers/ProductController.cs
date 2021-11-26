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
    public class ProductController : Controller
    {
        private readonly AcmeIncDbContext _context;
        ProductsUtil pUtil;

        public ProductController(AcmeIncDbContext context)
        {
            _context = context;
            pUtil = new ProductsUtil(context);
        }

        [HttpGet]
        public IActionResult Index(String searchTerm)
        {

           
            List<Product> products = new List<Product>();   //product list is populated based in the searchTerm provided

            if(searchTerm == null)                          //if navigating, there is no search term and all products are displayed
            {
                products = _context.Products.ToList();
            }
            else
            {

                if(searchTerm.IndexOf('0')==0)        //if the searchTerm starts with 0 indicates that the search term is a category id
                {                                     //filters the list based on the category id
                    int id1 = Convert.ToInt32(searchTerm.Substring(1));
                    products = pUtil.getFilteredProducts(id1);
                }
                else
                {
                    products = pUtil.getFilteredProductsSearch(searchTerm); // gets filtered list of products based on a search string based on name/desc of product
                }
            }

            ViewBag.Categories = pUtil.getCategories(); //populates the list of categories to be displayed 

           
            return View(products);
        }


        [HttpGet]
        public IActionResult Details(int id)
        {

            Product product = pUtil.getSingleProduct(id); //gets product based on the id passed in

            return View(product);
        }

        [HttpGet]
        public IActionResult CartDetails()
        {

            Cart cart = pUtil.getCartObject(HttpContext.Session.GetString("UserLoggedIn"));   //gets cart item for the user that is logged in

            return View(cart);
        }

        [HttpGet]
        public IActionResult AddToCart(int id)
        {

            if(HttpContext.Session.GetString("UserLoggedIn") == null)
            {

                TempData["NotLogged"] = "Not logged";     //temp data used in Details controller action to indicate that there are no users logged in
                return RedirectToAction("Details", "Product" , new {id = id });  //returns the Details view

            }
            else
            {
                //and and show cart
               if(pUtil.addedToCart(HttpContext.Session.GetString("UserLoggedIn"), id))  //adds or updates item in user's cart
                {
                    return RedirectToAction("CartDetails");  
                }

                else
                {
                   return RedirectToAction("Index", "Product");  //returns to the index page if there is an error
                }

            }

        }

        [HttpGet]
        public IActionResult CheckOut()
        {

           if(pUtil.checkedOut(HttpContext.Session.GetString("UserLoggedIn")))
            {
                TempData["OrderAdded"] = "Order Added";         //Tempdata used in UserHistory controller method to indicate a successful order
                return RedirectToAction("UserHistory", "User");
            }
            else
            {
                return RedirectToAction("Index", "Product");   //returns to the index page if there is an error
            }

        }

        [HttpGet]
        public ActionResult TrendDetails()
        {

            ViewData["Categories"] = getListCategories();   //populates list of categories to be displayed in the View
            ViewData["Error"] = TempData["DateError"];
            return View();
        }

        [HttpPost]
        public ActionResult TrendLine(TrendDetails td)
        {

            if(DateTime.Compare(td.Start, td.End) >0 )
            {
                    TempData["DateError"] = "Please ensure that the start date is earlier than the end date.";
                    return RedirectToAction("TrendDetails", "Product");
            }

            if(ModelState.IsValid)
            {
            var lstModel = new List<SimpleReportViewModel>();

            List<Order> orders = pUtil.getCategoryOrders(td); //list of orders for a category during a specific time

            List<DateTime> dates = pUtil.getDateRange(td);     // list of dates to set as x axis of graph

            ViewData["Category"] = pUtil.getCategoryName(td.CatId);

            foreach (DateTime item in dates)
            {

                int numOrders = pUtil.getOrdersForDay(item, orders);
                lstModel.Add(new SimpleReportViewModel(item.Date.ToString("D"), numOrders)); //adds number of orders per day to the list (the x and y points for graph)
            }

            return View(lstModel);
            }

            else
            {
                 return RedirectToAction("TrendDetails", "Product");
            }

            
        }
      


        public List<SelectListItem> getListCategories()         //gets the list of category id's and type 
        {
            List<SelectListItem> catItems = new List<SelectListItem>();
            List<Category> categories = pUtil.getCategories();

            foreach (Category category in categories)
            {
                    catItems.Add(new SelectListItem { Value = category.CatId + "", Text = category.Type });
            }

            return catItems;
        }



    }
}
