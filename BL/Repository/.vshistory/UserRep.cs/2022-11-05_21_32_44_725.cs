﻿using adressBook.BL.Interface;
using adressBook.DAL.Database;
using adressBook.DAL.Entities;
using adressBook.DAL.ViewModels;
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
                                            .FirstOrDefault();

            db.ContactPeople.Remove(contactPerson);
            db.SaveChanges();
        }

        public IEnumerable<ViewUserVM> Search(string entry)   // search of User with all fields
        {
            var data = db.ContactPeople.Where(a => a.MobileNo == entry || a.FullName == entry || a.Address == entry || a.Department.department == entry || a.Department.JobTitle == entry || a.Email == entry || a.HomeTelNo == entry)
                                       .Select(a => new ViewUserVM()
                                       {
                                           ID = a.ID,
                                           HomeTelNo = a.HomeTelNo,
                                           Email = a.Email,
                                           Address = a.Address,
                                           DateOfBirth = a.DateOfBirth,
                                           FullName = a.FullName,
                                           MobileNo = a.MobileNo,
                                           Photo = a.Photo,
                                           department = a.Department.department,
                                           JobTitle = a.Department.JobTitle
                                       });

            return data;
        }

        public async Task UpdateUser(int id, string address, string birthdate, int DepID, string email, string fullname, string hometel, string mobileno)
        {
            var user = await db.ContactPeople.FindAsync(id);

            user.Address = address;
            user.DateOfBirth = birthdate;
            user.DepID = DepID;
            user.Email = email;
            user.FullName = fullname;
            user.HomeTelNo = hometel;
            user.MobileNo = mobileno;

            //if (user != null && contactPerson.Address != null && contactPerson.DateOfBirth != null && contactPerson.DepID != 0 && contactPerson.Email != null && contactPerson.FullName != null && contactPerson.HomeTelNo != null && contactPerson.MobileNo != null)
            //{
            //    user.Address = contactPerson.Address;
            //    user.DateOfBirth = contactPerson.DateOfBirth;
            //    user.DepID = contactPerson.DepID;
            //    user.Email = contactPerson.Email;
            //    user.FullName = contactPerson.FullName;
            //    user.HomeTelNo = contactPerson.HomeTelNo;
            //    user.MobileNo = contactPerson.MobileNo;


            //}
            //else if(user != null && contactPerson.Address == null && contactPerson.DateOfBirth != null && contactPerson.DepID != 0 && contactPerson.Email != null && contactPerson.FullName != null && contactPerson.HomeTelNo != null && contactPerson.MobileNo != null)
            //{
            //    user.DateOfBirth = contactPerson.DateOfBirth;
            //    user.DepID = contactPerson.DepID;
            //    user.Email = contactPerson.Email;
            //    user.FullName = contactPerson.FullName;
            //    user.HomeTelNo = contactPerson.HomeTelNo;
            //    user.MobileNo = contactPerson.MobileNo;
            //}
            //else if (user != null && contactPerson.Address != null && contactPerson.DateOfBirth == null && contactPerson.DepID != 0 && contactPerson.Email != null && contactPerson.FullName != null && contactPerson.HomeTelNo != null && contactPerson.MobileNo != null)
            //{
            //    user.Address = contactPerson.Address;
            //    user.DepID = contactPerson.DepID;
            //    user.Email = contactPerson.Email;
            //    user.FullName = contactPerson.FullName;
            //    user.HomeTelNo = contactPerson.HomeTelNo;
            //    user.MobileNo = contactPerson.MobileNo;
            //}
            //else if (user != null && contactPerson.Address != null && contactPerson.DateOfBirth != null && contactPerson.DepID == 0 && contactPerson.Email != null && contactPerson.FullName != null && contactPerson.HomeTelNo != null && contactPerson.MobileNo != null)
            //{
            //    user.Address = contactPerson.Address;
            //    user.DateOfBirth = contactPerson.DateOfBirth;
            //    user.Email = contactPerson.Email;
            //    user.FullName = contactPerson.FullName;
            //    user.HomeTelNo = contactPerson.HomeTelNo;
            //    user.MobileNo = contactPerson.MobileNo;
            //}
            //else if (user != null && contactPerson.Address != null && contactPerson.DateOfBirth != null && contactPerson.DepID != 0 && contactPerson.Email == null && contactPerson.FullName != null && contactPerson.HomeTelNo != null && contactPerson.MobileNo != null)
            //{
            //    user.Address = contactPerson.Address;
            //    user.DateOfBirth = contactPerson.DateOfBirth;
            //    user.DepID = contactPerson.DepID;
            //    user.FullName = contactPerson.FullName;
            //    user.HomeTelNo = contactPerson.HomeTelNo;
            //    user.MobileNo = contactPerson.MobileNo;
            //}
            //else if (user != null && contactPerson.Address != null && contactPerson.DateOfBirth != null && contactPerson.DepID != 0 && contactPerson.Email != null && contactPerson.FullName == null && contactPerson.HomeTelNo != null && contactPerson.MobileNo != null)
            //{
            //    user.Address = contactPerson.Address;
            //    user.DateOfBirth = contactPerson.DateOfBirth;
            //    user.Email = contactPerson.Email;
            //    user.DepID = contactPerson.DepID;
            //    user.HomeTelNo = contactPerson.HomeTelNo;
            //    user.MobileNo = contactPerson.MobileNo;
            //}
            //else if (user != null && contactPerson.Address != null && contactPerson.DateOfBirth != null && contactPerson.DepID != 0 && contactPerson.Email != null && contactPerson.FullName != null && contactPerson.HomeTelNo == null && contactPerson.MobileNo != null)
            //{
            //    user.Address = contactPerson.Address;
            //    user.DateOfBirth = contactPerson.DateOfBirth;
            //    user.Email = contactPerson.Email;
            //    user.DepID = contactPerson.DepID;
            //    user.FullName = contactPerson.FullName;
            //    user.MobileNo = contactPerson.MobileNo;
            //}
            //else if (user != null && contactPerson.Address != null && contactPerson.DateOfBirth != null && contactPerson.DepID != 0 && contactPerson.Email != null && contactPerson.FullName != null && contactPerson.HomeTelNo != null && contactPerson.MobileNo == null)
            //{
            //    user.Address = contactPerson.Address;
            //    user.DateOfBirth = contactPerson.DateOfBirth;
            //    user.Email = contactPerson.Email;
            //    user.DepID = contactPerson.DepID;
            //    user.FullName = contactPerson.FullName;
            //    user.HomeTelNo = contactPerson.HomeTelNo;
            //}
            //else if (user != null && contactPerson.Address != null && contactPerson.DateOfBirth == null && contactPerson.DepID == 0 && contactPerson.Email == null && contactPerson.FullName == null && contactPerson.HomeTelNo == null && contactPerson.MobileNo == null)
            //{
            //    user.Address = contactPerson.Address;

            //}

            await db.SaveChangesAsync();
            //return contactPerson;
        }
    }
}
