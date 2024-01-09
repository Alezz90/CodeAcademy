using AcademyCode.BLL.Interface;
using CodeAcademy.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCode.BLL.Repo
{
    public class Repo<T> : IWorkUniit<T> where T : class
    {
       private AcademyDBContext _context;
     
        public Repo(AcademyDBContext context)
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

        public T Get(int id)
        => _context.Set<T>().Find(id);

        public IEnumerable<T> GetAll() => _context.Set<T>().ToList();
       
        public int Update(T obj)
        {
            _context.Set<T>().Update(obj);
            return _context.SaveChanges();
        }
    }
}
