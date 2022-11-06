using adressBook.BL.Repository;
using adressBook.DAL.Database;
using adressBook.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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


        private async Task<string> WriteFile(int id, IFormFile file, [FromForm]ContactPerson contactPerson)
        {
            string fileName = "";

            try
            {
                var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
                fileName = DateTime.Now.Ticks + extension;
                var pathBuilt = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\Images");

                if (!Directory.Exists(pathBuilt))
                {
                    Directory.CreateDirectory(pathBuilt);

                }
                var path = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\Images", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                contactPerson.Photo = fileName;
                db.ContactPeople.Update(contactPerson);
                User.UpdateUser(id, contactPerson);

            }
        }
    }
}
