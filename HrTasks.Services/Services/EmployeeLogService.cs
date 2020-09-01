using AutoMapper;
using HrTasks.Model.Entites;
using HrTasks.ModelAccess;
using HrTasks.Services.Dto;
using HrTasks.Services.Interfaces;
using HrTasks.Services.Services.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrTasks.Services.Services
{
  public  class EmployeeLogService : BaseServices, IEmployeeLogService
    {
        public EmployeeLogService(IMapper mapper, IUnitofWork unitofWork)
         : base(mapper, unitofWork) { }

        public IEnumerable<EmployeeLogDto> GetAll()
        {
            var list = _unitofWork.EmployeeLogRepository.GetAll(source => source.Include(u => u.Employees));
            return _mapper.Map<IEnumerable<EmployeeLogDto>>(list);
        }
        public EmployeeLogDto Get(int id)
        {
            var EmployeeLog = _unitofWork.EmployeeLogRepository.Get(id);
            return _mapper.Map<EmployeeLogDto>(EmployeeLog);
        }
        public void Add(EmployeeLogDto EmployeeLogDto)
        {
            var EmployeeLog = _mapper.Map<EmployeeLogDto, EmployeeLog>(EmployeeLogDto);
            _unitofWork.EmployeeLogRepository.Add(EmployeeLog);
            _unitofWork.SaveChanges();
        }
        public void Update(EmployeeLogDto EmployeeLogDto)
        {
            var EmployeeLog = _unitofWork.EmployeeLogRepository.Get(EmployeeLogDto.Id);
            _mapper.Map(EmployeeLogDto, EmployeeLog);

            _unitofWork.SaveChanges();
        }
        public void Delete(int id)
        {
            var EmployeeLog = _unitofWork.EmployeeLogRepository.Get(id);
            if (EmployeeLog != null)
            {
                _unitofWork.EmployeeLogRepository.Remove(EmployeeLog);

                _unitofWork.SaveChanges();
            }
        }
    }
}
