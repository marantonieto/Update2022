using Marantonieto.Data;
using Marantonieto.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Marantonieto.Services
{
    public class DepartmentService
    {
        private readonly MarantonietoContext _context;

        public DepartmentService(MarantonietoContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(d => d.Name).ToList();
        }
    }
}
