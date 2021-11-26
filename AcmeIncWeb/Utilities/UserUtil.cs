using AcmeIncWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AcmeIncWeb.Utilities
{
    public class UserUtil                                   //class handles interactions with db for products
    {

        static AcmeIncDbContext db = new AcmeIncDbContext();

        public UserUtil(AcmeIncDbContext context)
        {
            db = context;
        }

        public bool userValid(String email, String password)
        {
            try
            {
                String pword = SHA1(password);               //creates a hash value of the password entered in by the user
                User user = db.Users.Where(u => u.Email.Equals(email) && u.Password.Equals(pword)).FirstOrDefault(); // gets a user object from the db based on email and password provided

                if (user != null)  //if there is a user
                {
                    return true; 
                }
                else               //if there is no user
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
            

        }


        public bool userExists(String email)          //returns whether user is a duplicate 
        {
            User user = db.Users.Where(u => u.Email.Equals(email)).FirstOrDefault();  // gets a user object from the db based on email and password provided

            if (user != null) //if there is a user
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool customerAdded(User user)
        {
            try
            {
                if (!userExists(user.Email))  //if there is not a duplicate user
                {

                    String pword = SHA1(user.Password);     //gets the hash value of the password
                    user.Password = pword;                  // sets the password property of the object to the hash value
                    db.Users.Add(user);

                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<User> getUsers()
        {
            return db.Users.Include(r => r.Role).ToList();       //returns list of users 
        }

        public List<Role> getRoles()
        {

            return db.Roles.ToList();                           //returns list of all roles
        }

        public int getUserRole(String email)
        {
            User user = db.Users.Where(u => u.Email.Equals(email)).FirstOrDefault();    //gets user object based on email passed in

            return user.RoleId;
        }

        //------------------------------------------------CODE ATTRIBUTION-------------------------------------
        // Author:  HazardEdit
        //Date: 1 December 2015
        // Available at: https://www.youtube.com/watch?v=VDpyJqqTFts

        public static string SHA1(string input)         //creating hash value 
        {
            byte[] hash;
            using (var sha1 = new SHA1CryptoServiceProvider())
            {

                hash = sha1.ComputeHash(Encoding.Unicode.GetBytes(input));
            }

            var sb = new StringBuilder();

            foreach (byte b in hash)
            {
                sb.AppendFormat("{0:x2}", b);
            }

            return sb.ToString();
        }

        //-----------------------------------------------------------------------------------------------------------

        public List<Order> getUserOrders(String email)
        {
            User user = db.Users.Where(x => x.Email == email).FirstOrDefault();
            return db.Orders.Where(u => u.UserId == user.UserId).Include(p => p.Prod).ToList();  //returns list of previous orders for a user
        }

    }
}
