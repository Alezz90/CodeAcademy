using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCode.BLL.Interface
{
    public interface IUnitOfWork
    {
       public IEmployee EployeeRepo { get; set; }
        public IDepartment DepartmentRepo { get; set; }
    }
    
    }

