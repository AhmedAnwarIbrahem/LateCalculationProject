using System;
using System.Collections.Generic;
using System.Text;

namespace HrTasks.Services.Dto
{
  public  class EmployeeLogDto
    {
        public int? Id { get; set; }
        public string Description { get; set; }
        public DateTime DayDate { get; set; }
        public TimeSpan? LogIn { get; set; }
        public TimeSpan? LogOut { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeNameAr { get; set; }
        public string EmployeeNameEn { get; set; }

    }
}
