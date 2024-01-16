using AcademyCode.DAL.Model;
using AcademyCode.ModelsVM;
using AutoMapper;

namespace AcademyCode.ModelProfile
{
    public class DepatmentProfile:Profile
    {
        public DepatmentProfile() {
            CreateMap<DepartmentVM, Department>();
                }
    }
}
