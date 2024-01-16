using AcademyCode.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyCode.BLL.Interface
{
    public interface IEmployee:IGeneric<Employee>
    {
        IEnumerable<Employee> Search(string name);

    }
}
