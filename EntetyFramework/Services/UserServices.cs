using EntityFramework.Database;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Services
{
    internal interface IUserService
    {
        bool Create(string firstname, string lastname, string email, string phonenumber, string address, string postalcode, string city, string country);
        IEnumerable<Customer> GetAll();
    }
    internal class UserService : IUserService
    {
        private readonly SqlContext _context = new();
        public bool Create(string firstname, string lastname, string email, string phonenumber, string address, string postalcode, string city, string country)
        {
            var Customer = _context.Customers.Where(x => x.Email == email).FirstOrDefault();
            if (Customer == null)
            {
                _context.Customers.Add(new Customer
                {
                    
                    FirstName = firstname,
                    LastName = lastname,
                    Email = email,
                    PhoneNumber = phonenumber,
                    AdressName = address,
                    PostalCode = postalcode,
                    City = city,
                    Country = country

                });
                _context.SaveChanges();
                return true;
            }
            return false;       
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers;
        }
    }
}
