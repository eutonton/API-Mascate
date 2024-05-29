using API_Mascate.DTOs.employeeDTO;
using API_Mascate.Model.employee;
using AutoMapper;

namespace API_Mascate.Mapping
{
    public class DomaintoDTOMapping : Profile 
    {
        public DomaintoDTOMapping() 
        {
            CreateMap<Employee, CreatorEmployDTO>();
        }
    }
}
