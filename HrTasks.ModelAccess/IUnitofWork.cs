﻿using HrTasks.ModelAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrTasks.ModelAccess
{
  public  interface IUnitofWork : IDisposable
    {
        EmployeeRepository EmployeeRepository { get; }
        DepartmentRepository DepartmentRepository { get; }
        EmployeeTaskRepository EmployeeTaskRepository { get; }

        int SaveChanges();
    }
}
