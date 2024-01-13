using AcademyCode.BLL.Interface;
using AcademyCode.DAL.Data;
using AcademyCode.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCode.BLL.Repo
{
    public class DepartmentRepo : UnitOfWork<Department>, IDepartment
    {
        public DepartmentRepo(AcademyDBContext context) : base(context) { }
    }

}
