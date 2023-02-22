using adressBook.BL.Repository;
using adressBook.DAL.Database;
using adressBook.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adressBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        DepRep Dep = new DepRep();
        DbContainer db = new DbContainer();

        [HttpPost("AddNewJob")]
        public IActionResult AddJob(Department dpt) //Add new job title or department
        {
            try
            {
                return Ok(Dep.AddNewJob(dpt));
            }
            catch (Exception ex)
            {
                return Ok(ex.InnerException.Message);
            }

        }

        [HttpPut("UpdateDepartment")]
        public IActionResult UpdateDepartment(Department dpt)  // Edit Job Title or Department in Department Table by Department ID
        {
            try
            {
                return Ok( Dep.EditDepartment(dpt));
            }
            catch (Exception ex)
            {
                return Ok(ex.InnerException.Message);
            }
        }

        [HttpDelete("DeleteDepartment")]
        public IActionResult DeletePerson(int depid)           //Delete Department from Department Table
        {
            try
            {
                return Ok( Dep.DeleteDepartment(depid) );
            }
            catch (Exception ex)
            {
                return Ok(ex.InnerException.Message);
            }
        }
               
    }
}
