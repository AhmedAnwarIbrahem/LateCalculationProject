using AutoMapper;
using HrTasks.Model.Entites;
using HrTasks.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrTasks.Services.AutoMapper
{
    public class HrTasksMapper : Profile
    {
        public HrTasksMapper(){

            CreateMap<EmployeeDto, Employee>().ReverseMap();
            CreateMap<EmployeeLogDto, EmployeeLog>().ReverseMap().ForMember(p => p.EmployeeNameAr, d => d.MapFrom(u => (u.EmployeeId != null) ? u.Employees.EmployeeNameAr : string.Empty)).ForMember(p => p.EmployeeNameEn, d => d.MapFrom(u => (u.EmployeeId != null) ? u.Employees.EmployeeNameEn : string.Empty));


        }
    }
}
