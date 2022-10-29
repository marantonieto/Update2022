﻿using System;
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
        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(s => s.Id == id);
        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
