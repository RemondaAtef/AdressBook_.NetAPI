﻿using adressBook.DAL.Entities;
using adressBook.DAL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace adressBook.BL.Interface
{
    public interface IUserRep
    {
        void DeleteUser(int id);  //Delete User from ContactPerson Table
        IEnumerable<ViewUserVM> Search(string entry);   // search of User with all fields
        Task UpdateUser(int id, string address, string birthdate, int DepID, string email, string fullname, string hometel, string mobileno);
    }
}