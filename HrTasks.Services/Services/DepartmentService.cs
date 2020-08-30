using AutoMapper;
using HrTasks.Model.Entites;
using HrTasks.ModelAccess;
using HrTasks.Services.Dto;
using HrTasks.Services.Interfaces;
using HrTasks.Services.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrTasks.Services.Services
{
  public  class DepartmentService : BaseServices, IDepartmentService
    {
        public DepartmentService(IMapper mapper, IUnitofWork unitofWork)
         : base(mapper, unitofWork) { }

        public IEnumerable<DepartmentDto> GetAll()
        {
            var list = _unitofWork.DepartmentRepository.GetAll();
            return _mapper.Map<IEnumerable<DepartmentDto>>(list);
        }
        public DepartmentDto Get(int id)
        {
            var Department = _unitofWork.DepartmentRepository.Get(id);
            return _mapper.Map<DepartmentDto>(Department);
        }
        public void Add(DepartmentDto DepartmentDto)
        {
            var Department = _mapper.Map<DepartmentDto, Department>(DepartmentDto);
            _unitofWork.DepartmentRepository.Add(Department);
            _unitofWork.SaveChanges();
        }
        public void Update(DepartmentDto DepartmentDto)
        {
            var Department = _unitofWork.DepartmentRepository.Get(DepartmentDto.Id);
            _mapper.Map(DepartmentDto, Department);

            _unitofWork.SaveChanges();
        }
        public void Delete(int id)
        {
            var Department = _unitofWork.DepartmentRepository.Get(id);
            if (Department != null)
            {
                _unitofWork.DepartmentRepository.Remove(Department);

                _unitofWork.SaveChanges();
            }
        }
    }
}
