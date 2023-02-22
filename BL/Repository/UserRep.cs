using adressBook.BL.Interface;
using adressBook.DAL.Database;
using adressBook.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adressBook.BL.Repository
{
    public class UserRep : IUserRep
    {
        DbContainer db = new DbContainer();
        public bool DeleteUser(int id)        //Delete User from ContactPerson Table
        {
            var contactPerson = db.ContactPeople.Find(id);

            if (contactPerson == null)
            {
                return false;
            }
            db.Remove(contactPerson);
            return db.SaveChanges() > 0;
            
        }

        public List<ContactPerson> Search(string entry, DateTime fromDate, DateTime toDate, int age)   // search of User with all fields 
        {
            try
            {
                if (!string.IsNullOrEmpty(entry) || age != 0 || fromDate != DateTime.MinValue && toDate != DateTime.MinValue)
                {
                    var data = db.ContactPeople.Where(a => a.MobileNo == entry || a.FullName == entry || a.Address == entry || a.Department.department == entry || a.Department.JobTitle == entry || a.Email == entry || a.HomeTelNo == entry ||
                    (DateTime.Now.Date.Year - a.DateOfBirth.Value.Date.Year) == age ||
                   (a.DateOfBirth >= fromDate.Date && a.DateOfBirth <= toDate.Date)).ToList();
                    return data;
                }

                return null;
               
            }
            catch (Exception ex)
            {
               throw ex.InnerException;
            }

        }

        public bool UpdateUser(ContactPerson contactPerson)              //Update User by write all data of him
        {
            var oldData = db.ContactPeople.SingleOrDefault(u => u.ID == contactPerson.ID);

            if(oldData == null)
            {
                return false;
            }
            db.Entry(oldData).State = EntityState.Modified;
            db.Entry(oldData).CurrentValues.SetValues(contactPerson);
           
            return db.SaveChanges() > 0;

        }

    }
}
