using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrTasks.Services.Dto;
using HrTasks.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HrTasks.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeLogsController : ControllerBase
    {
        private IEmployeeLogService _EmployeeLogService;
        public EmployeeLogsController(IEmployeeLogService EmployeeLogService) 
        {
            _EmployeeLogService = EmployeeLogService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _EmployeeLogService.GetAll();

            return Ok(list);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var EmployeeLogs = _EmployeeLogService.Get(id);

            return Ok(EmployeeLogs);
        }
        [HttpPost]
        public IActionResult Add(EmployeeLogDto EmployeeLogDto)
        {
            _EmployeeLogService.Add(EmployeeLogDto);

            return Ok();
        }
        [HttpPut()]
        public IActionResult Update(EmployeeLogDto EmployeeLogDto)
        {
            _EmployeeLogService.Update(EmployeeLogDto);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _EmployeeLogService.Delete(id);

            return Ok();
        }

        [HttpGet("{empId}")]
        public IActionResult GetAllLogsByEmpId(int empId)
        {
            var list = _EmployeeLogService.GetAll().Where(a => a.EmployeeId == empId).ToList();
            return Ok(list);
        }
    }
}