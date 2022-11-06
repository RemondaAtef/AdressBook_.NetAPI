using adressBook.BL.Repository;
using adressBook.DAL.Database;
using adressBook.DAL.Entities;
using adressBook.DAL.ViewModels;
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
           Dep.AddNewJob(dpt);

            return Ok();
        }

        [HttpPut("UpdateDepartment/{id}")]
        public async Task<IActionResult> UpdateDepartment([FromRoute] int id, string dep, string job)  // Edit Job Title or Department in Department Table by Department ID
        {
            await Dep.EditDepartment(id, dep, job);

            return Ok();
        }

        [HttpDelete("DeleteDepartment")]
        public void DeletePerson(int depid)           //Delete Department from Department Table
        {
            Dep.DeleteDepartment(depid);
        }
               
    }
}
