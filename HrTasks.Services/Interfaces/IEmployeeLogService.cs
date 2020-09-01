using System.Collections.Generic;
using HrTasks.Services.Dto;

namespace HrTasks.Services.Interfaces
{
    public interface IEmployeeLogService
    {
        void Add(EmployeeLogDto EmployeeLogDto);
        void Delete(int id);
        EmployeeLogDto Get(int id);
        IEnumerable<EmployeeLogDto> GetAll();
        void Update(EmployeeLogDto EmployeeLogDto);
    }
}