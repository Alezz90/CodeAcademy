using AcademyCode.BLL.Interface;
using AcademyCode.DAL.Data;
using AcademyCode.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCode.BLL.Repo
{
    public class EmployeeRepo : GenirecRepo<Employee>, IEmployee
    {
        private readonly AcademyDBContext _context;

        public EmployeeRepo(AcademyDBContext context) : base(context) {
            _context = context;

        }
         
        public IEnumerable<Employee> Search(string Name)
        {

            var emp = _context.Employees.Where(e => e.Name.ToLower().Contains(Name.ToLower())).ToList();

            return emp;

        }
    }

}
