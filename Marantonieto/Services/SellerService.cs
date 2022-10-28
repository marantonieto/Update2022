using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marantonieto.Data;
using Marantonieto.Models;

namespace Marantonieto.Services
{
    public class SellerService
    {
        private readonly MarantonietoContext _context;

        public SellerService(MarantonietoContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
