﻿using adressBook.BL.Repository;
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
        public void DeletePerson (int id)
        {
            User.DeleteUser(id);
        }

        public IActionResult FindUsers(string entry)
        {
            var data = User.Search(entry);

            return Ok(data);
        }
    }
}
