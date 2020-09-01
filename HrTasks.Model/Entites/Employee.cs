using System;
using System.Collections.Generic;
using System.Text;

namespace HrTasks.Model.Entites
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeNameAr { get; set; }
        public string EmployeeNameEn { get; set; }
        public DateTime JoinDate { get; set; }
        public virtual ICollection<EmployeeLog> EmployeeLogs { get; set; }

    }
}
