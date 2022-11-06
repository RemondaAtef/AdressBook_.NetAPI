using adressBook.DAL.Entities;
using adressBook.DAL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace adressBook.BL.Interface
{
    public interface IUserRep
    {
        void DeleteUser(int id);  //Delete User from ContactPerson Table
        IEnumerable<ViewUserVM> Search(string entry);   // search of User with all fields (Mobile phone || full name || address || department name || job title || email || home telephone)
        Task UpdateUser(ContactPerson contactPerson);  //Update User by write all data of him
    }
}