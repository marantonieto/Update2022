using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Marantonieto.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} should have between {2} and {1} characters")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Range(1200.00, 60000.00, ErrorMessage = "{0} should be between {1} and {2}")]
        public double BaseSalary { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
        public Department Department { get; set; }
        public int DepartmentId { get; set; }

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddSales(SalesRecord sale)
        {
            Sales.Add(sale);
        }
        public void RemoveSales(SalesRecord sale)
        {
            Sales.Remove(sale);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
