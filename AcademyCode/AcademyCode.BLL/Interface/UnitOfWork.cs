using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCode.BLL.Interface
{
    public interface IUnitOfWork<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        // 
        int Create(T obj);
        int Update(T obj);
        int Delete(T obj);
    }
    
    }

