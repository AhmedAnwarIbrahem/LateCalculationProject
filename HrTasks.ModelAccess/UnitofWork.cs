using HrTasks.Model;
using HrTasks.ModelAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrTasks.ModelAccess
{
  public  class UnitofWork:IUnitofWork
    {
        private readonly HrTasksContext _context;

        public UnitofWork(HrTasksContext Context)
        {
            _context = Context;
        }

        public EmployeeRepository EmployeeRepository
        {
            get
            {
                return new EmployeeRepository(_context);
            }
        }
        public DepartmentRepository DepartmentRepository
        {
            get
            {
                return new DepartmentRepository(_context);
            }
        }

        public EmployeeTaskRepository EmployeeTaskRepository
        {
            get
            {
                return new EmployeeTaskRepository(_context);
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
