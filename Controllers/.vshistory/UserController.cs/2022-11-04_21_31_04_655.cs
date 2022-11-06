using adressBook.BL.Repository;
using adressBook.DAL.Database;
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
    public class UserController : ControllerBase
    {
        new UserRep User = new UserRep();
        DbContainer db = new DbContainer();

        [HttpDelete("DeletePerson")]
        public void DeletePerson (int id)           //Delete User from ContactPerson Table
        {
            User.DeleteUser(id);
        }

        [HttpGet("SearchUsers")]
        public IActionResult FindUsers(string entry)   // search of User with all fields
        {
            var data = User.Search(entry);

            return Ok(data);
        }
    }
}
