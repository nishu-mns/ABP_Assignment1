using Assigment.Dtos;
using Assigment.Entity;
using AutoMapper;

namespace Assigment;

public class AssigmentApplicationAutoMapperProfile : Profile
{
    public AssigmentApplicationAutoMapperProfile()
    {
        CreateMap<CreateEmployeeDto, Employee>();
        CreateMap<Employee, EmployeeDto>().ReverseMap();
    }
}
