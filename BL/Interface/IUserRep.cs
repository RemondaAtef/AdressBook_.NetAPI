using adressBook.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace adressBook.BL.Interface
{
    public interface IUserRep
    {
        bool DeleteUser(int id);   //Delete User from ContactPerson Table
        bool UpdateUser(ContactPerson contactPerson);
        List<ContactPerson> Search(string entry, DateTime fromDate, DateTime toDate, int age);
    }
}
