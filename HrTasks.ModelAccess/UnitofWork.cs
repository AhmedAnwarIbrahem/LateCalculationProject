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

        public EmployeeLogRepository EmployeeLogRepository
        {
            get
            {
                return new EmployeeLogRepository(_context);
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
