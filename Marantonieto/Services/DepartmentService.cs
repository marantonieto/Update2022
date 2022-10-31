using Marantonieto.Data;
using Marantonieto.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marantonieto.Services
{
    public class DepartmentService
    {
        private readonly MarantonietoContext _context;

        public DepartmentService(MarantonietoContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(d => d.Name).ToListAsync();
        }
    }
}
