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
        public IActionResult AddNewJob(Department dpt) //Add new job title or department
        {
            Dep.AddNewJob(dpt);

            return Ok();
        }
    }
}
