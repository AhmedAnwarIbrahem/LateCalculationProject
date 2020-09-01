using Common;
using HrTasks.Model;
using HrTasks.Model.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrTasks.ModelAccess.Repositories
{
    public class EmployeeLogRepository : Repository<EmployeeLog>
    {
        public EmployeeLogRepository(HrTasksContext context) : base(context)
        {
        }
    }
    
}
