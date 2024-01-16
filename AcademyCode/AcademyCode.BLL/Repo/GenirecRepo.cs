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
    public class GenirecRepo<T> :IGeneric<T> where T : class
    {
        private AcademyDBContext _context;

        public GenirecRepo(AcademyDBContext context)
        {
            _context = context;

        }
        public int Create(T obj)
        {

            _context.Set<T>().Add(obj);
            return _context.SaveChanges();
        }

        public int Delete(T obj)
        {
            _context.Set<T>().Remove(obj);
            return _context.SaveChanges();
        }

        public T Get(int id) => _context.Set<T>().Find(id);

        public IEnumerable<T> GetAll()
        {
            if (typeof(T) == typeof(Employee))
            {
                return (IEnumerable<T>)_context.Employees.Include(e => e.Department).ToList();

            }
            else
            {
                return _context.Set<T>().ToList();

            }
        }

        public int Update(T obj)
        {
            _context.Set<T>().Update(obj);
            return _context.SaveChanges();
        }
    
   
    }
}
