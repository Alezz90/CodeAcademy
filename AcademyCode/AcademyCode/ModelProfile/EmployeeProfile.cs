using AcademyCode.DAL.Model;
using AcademyCode.ModelsVM;
using AutoMapper;

namespace AcademyCode.ModelProfile
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeVM, Employee>();
        }
    }
}
