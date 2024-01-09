using AcademyCode.BLL.Interface;
using CodeAcademy.DAL.Data;
using CodeAcademy.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCode.BLL.Repo
{
    public class DepartmentRepo : Repo<Department>, IDepartment
    {
        public DepartmentRepo(AcademyDBContext context) : base(context) { }
    }
}
