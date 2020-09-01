using HrTasks.ModelAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrTasks.ModelAccess
{
  public  interface IUnitofWork : IDisposable
    {
        EmployeeRepository EmployeeRepository { get; }
        EmployeeLogRepository EmployeeLogRepository { get; }

        int SaveChanges();
    }
}
