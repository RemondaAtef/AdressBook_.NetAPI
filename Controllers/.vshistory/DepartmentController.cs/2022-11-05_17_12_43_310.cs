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

        [HttpPut("UpdateDepartments")]
        public IActionResult UpdateDepartment(int id, string dep, string job)  // Edit Job Title or Department in Department Table by Department ID
        {
            var data = Dep.EditDepartment(id, dep, job);

            return Ok(data);
        }

        [HttpDelete("DeleteDepartment")]
        public void DeletePerson(int depid)           //Delete Department from Department Table
        {
            Dep.DeleteDepartment(depid);
        }

        //[HttpGet("GetDepartment")]
        //public IActionResult FindUsers(int id)   
        //{
        //    var data = Dep.ViewDepByID(id);

        //    return Ok(data);
        //}

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDepData([FromRoute]int id, [FromBody] Department department)
        {
            await Dep.UpdataDepartment(id, department);

            return Ok();
            //try
            //{
            //    if(viewDepVM == null)
            //    {
            //        return BadRequest();
            //    }

            //    var CurrentID = User.Claims.ToList().FirstOrDefault(a => a.Type == "id").Value;

            //    var dept = new Department
            //    {
            //        department = viewDepVM.department,
            //        JobTitle = viewDepVM.JobTitle
            //    };

            //    bool result = await Dep.UpdataDepartment(dept, CurrentID);

            //    if(result)
            //    {
            //        return Ok();
            //    }
            //    return BadRequest();
            //}
            //catch(Exception)
            //{
            //    throw;
            //}
        }
    }
}
