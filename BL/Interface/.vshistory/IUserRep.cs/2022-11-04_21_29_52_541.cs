using adressBook.DAL.ViewModels;
using System.Collections.Generic;

namespace adressBook.BL.Interface
{
    public interface IUserRep
    {
        void DeleteUser(int id);  //Delete User from ContactPerson Table
        IEnumerable<ViewUserVM> Search(string entry);   // search of User with all fields

    }
}