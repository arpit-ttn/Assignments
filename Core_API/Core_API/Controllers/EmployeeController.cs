using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Core_API.Data;
using Core_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employee;
        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }
        [HttpGet]
        public IActionResult GetData()
        {

            DataSet ds = _employee.GetData();
            return Ok(ds);
        }
        [HttpGet("{id}")]
        public IActionResult GetDataId(int id)
        {
            DataSet ds = _employee.GetDataId(id);
            return Ok(ds);
        }

        [HttpPost]
        public ActionResult<bool> InsertData(Employee employee)
        {

            try
            {
                if (employee == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _employee.InsertData(employee);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " unable to insert data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpPut("{id}")]
        public ActionResult<bool> UpdateData(int id, Employee employee)
        {

            try
            {
                if (employee == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _employee.UpdateData(id, employee);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " unable to insert data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteData(int id)
        {

            Employee employee = new Employee();

            try
            {
                if (employee == null)
                {
                    return Ok(BadRequest());
                }

                bool result = _employee.DeleteData(id);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " unable to insert data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}