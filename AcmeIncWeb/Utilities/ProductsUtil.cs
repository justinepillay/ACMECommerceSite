using AcmeIncWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeIncWeb.Utilities
{

    public class ProductsUtil                                      //class handles interactions with db for products
    {
       
        static AcmeIncDbContext db = new AcmeIncDbContext();

        public ProductsUtil(AcmeIncDbContext context)
        {
            db = context;
        }

        public List<Product> getAllProducts()
        { 
            return db.Products.Include(p => p.Cat).ToList();      //returns list of all products 
        }

        public List<Product> getFilteredProducts(int id )
        {
            return db.Products.Where(p => p.CatId == id).ToList(); // returns list of all products in a certain category
        }

        public List<Product> getFilteredProductsSearch(String searchTerm)
        {
            return db.Products.Where(p => p.Name.Contains(searchTerm)|| p.Description.Contains(searchTerm)).ToList();  // returns list of all products where name/desc contains the search term
        }

        public List<Category> getCategories()
        { 
            return db.Categories.ToList();       //returns list of all categories
        }

        public Product getSingleProduct(int id)
        {
            return db.Products.Where(p => p.ProdId == id).Include(c => c.Cat).FirstOrDefault();    //returns product item based on the product id passed in
        }

        public Cart getCartObject(String email)
        {
            User user = db.Users.Where(u => u.Email.Equals(email)).FirstOrDefault();       //gets the user object from db based on email passed in
             
            Cart cart = db.Carts.Where(c => c.UserId == user.UserId).Include(p => p.Prod).Include(x => x.User).FirstOrDefault();  //gets the cart object of the user object
            
            return cart;
        }

        public bool addedToCart(String email, int prodId)
        {
            bool added = false;

            try
            {
                User user = db.Users.Where(u => u.Email.Equals(email)).FirstOrDefault();        //gets the user object from db based on email passed in
                Cart cart = db.Carts.Where(c => c.UserId == user.UserId).FirstOrDefault();   //gets the cart object based on the user id

                if (cart == null)           //if there are no current cart items for the user
                {
                    cart = new Cart();           //create a new cart item 
                    cart.UserId = user.UserId;   //set the user id property
                    cart.ProdId = prodId;        //set the product id variable based on id passed in
                    db.Add(cart);                //adds the object to the database
                    db.SaveChanges();
                }
                else   //if there is already a cart object
                {
                    cart.ProdId = prodId;    // updates the product id property
                    db.Update(cart);         //updates the cart object
                    db.SaveChanges();
                }


                added = true;

            }
            catch(Exception ex)
            {
                added = false;
            }

            return added;
        }

        public bool checkedOut(String email)
        {
            bool checkedOut = false;

            try
            {
                User user = db.Users.Where(u => u.Email.Equals(email)).FirstOrDefault();      //gets the user object from db based on email passed in
                Cart cart = db.Carts.Where(c => c.UserId == user.UserId).FirstOrDefault();    //gets the cart object based on the user id
                DateTime localDate = DateTime.Now;

                Order order = new Order();
                order.UserId = user.UserId;     //set property of user id in order object
                order.Date = localDate;         //set property of date in order object
                order.ProdId = cart.ProdId;     //set property of product id in order object

                db.Add(order);   //adds the order to db
                db.Remove(cart); // removes the cart objct to 'empty the cart'
                db.SaveChanges();

                checkedOut = true;

            }
            catch(Exception ex)
            {
                checkedOut = false;
            }

            return checkedOut;
        }

        public List<Order> getCategoryOrders(TrendDetails td)
        {
            List<Order> filteredOrders = new List<Order>();

            List<Product> products = db.Products.Where(p => p.CatId == td.CatId).ToList();    //gets list of products for a certain category

            List<Order> orders = db.Orders.ToList();                         //gets list of all orders

            foreach (Order order in orders)
            {
                foreach (Product product in products)
                {

                    if (order.ProdId == product.ProdId)             //if product id in products list equals order product id, add to list
                    {
                        filteredOrders.Add(order);
                    }
                }
            }

            filteredOrders = filteredOrders.Where(o => (DateTime.Compare(td.Start.Date, o.Date.Date) <= 0 && DateTime.Compare(td.End.Date, o.Date.Date) >= 0)).ToList(); //filters list to get the orders from start and end date

            return filteredOrders;
        }

        public List<DateTime> getDateRange(TrendDetails td)              //returns list of dates for a specific range
        {
            List<DateTime> dates = new List<DateTime>();
            DateTime startDate = td.Start;
            DateTime endDate = td.End;

            while (startDate <= endDate)     // while the start date is still < the end date
            {
              dates.Add(startDate);           //add start date to list
              startDate = startDate.AddDays(1); //update start date to a day later
            }

            return dates;
        }

        public String getCategoryName(int catId)      //return the name of the category based on id passed in
        { 

            Category cat = db.Categories.Where(c => c.CatId == catId).FirstOrDefault();  //gets the category object from the database
            return cat.Type;
        }

        public int getOrdersForDay(DateTime day, List<Order> orders)   //get the amount of orders that occured on a day 
        {
            int numOrders = 0;

            List<Order> ordersForDay = orders.Where(o => (DateTime.Compare(day.Date, o.Date.Date) == 0)).ToList(); // gets the list of orders for a day

            if(ordersForDay.Count > 0 )
            {
                numOrders = ordersForDay.Count;
            }

            return numOrders;
        }

      

    }
}
