using adressBook.BL.Interface;
using adressBook.DAL.Database;
using adressBook.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adressBook.BL.Repository
{
    public class UserRep : IUserRep
    {
        DbContainer db = new DbContainer();
        public void DeleteUser(int id)        //Delete User from ContactPerson Table
        {
            ContactPerson contactPerson;

            contactPerson = db.ContactPeople.Where(a => a.ID == id)
                                            .First();

            db.ContactPeople.Remove(contactPerson);
            db.SaveChanges();
        }

        public IEnumerable<ContactPerson> Search(string entry)
        {
            var data = db.ContactPeople.Where(a => a.MobileNo == entry || a.FullName == entry || a.Address == entry || a.Department.department == entry || a.Department.JobTitle == entry || a.Email == entry || a.HomeTelNo == entry)
                                       .Select(a => new ContactPerson() { ID = a.ID, HomeTelNo = a.HomeTelNo, Email = a.Email , Address = a.Address, DateOfBirth = a.DateOfBirth, FullName = a.FullName, MobileNo = a.MobileNo, Photo = a.Photo});

            return data;
        }
    }
}
