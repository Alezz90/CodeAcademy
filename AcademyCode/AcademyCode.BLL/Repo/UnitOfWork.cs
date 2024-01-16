using AcademyCode.BLL.Interface;
using AcademyCode.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCode.BLL.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        public IEmployee EployeeRepo { get ; set ; }
        public IDepartment DepartmentRepo { get ; set; }

        public UnitOfWork(AcademyDBContext context) {

        EployeeRepo = new EmployeeRepo(context);
        DepartmentRepo = new DepartmentRepo(context);

        }
    
    }
}
