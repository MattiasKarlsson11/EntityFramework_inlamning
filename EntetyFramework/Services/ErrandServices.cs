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
    internal interface IErrandServices
    {
        bool Create(string errandtitle, string erranddescription, string errandstatus, int customerid);
        IEnumerable<Errand> GetAll();
    }
    internal class ErrandServices : IErrandServices
    {
        private readonly SqlContext _context = new();
        public bool Create(string errandtitle, string erranddescription, string errandstatus, int customerid)
        {
            var Errand = _context.Errands.Where(x => x.ErrandTitel == errandtitle).FirstOrDefault();
            if(Errand == null)
            {
                _context.Errands.Add(new Errand
                {
                    ErrandTitel = errandtitle,
                    ErrandSpecipication = erranddescription,
                    ErrandTime = DateTime.Now,
                    ErrandStatus = errandstatus,
                    CustomerId = customerid,
                   
                });
                _context.SaveChanges();
                return true;

               
            }
            return false;
        }

        public IEnumerable<Errand> GetAll()
        {
            return _context.Errands.Include(x => x.Customer);
        }
    }
}
