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
    public class DepRep : IDepRep
    {
        DbContainer db = new DbContainer();
        public Department AddNewJob(Department dpt)    //Add new job title or department
        {        
                     
                db.Departments.Add(dpt);
                db.SaveChanges();
                return dpt;
           
        }

        public bool EditDepartment(Department department)    // Edit Job Title or Department in Department Table by Department ID
        {
            var Olddata = db.Departments.SingleOrDefault(s => s.DepID == department.DepID);    //search with id 

            if (Olddata == null)
            {
                return false;
            }

            db.Entry(Olddata).State = EntityState.Modified;
           
            db.Entry(Olddata).CurrentValues.SetValues(department);  
            return db.SaveChanges() > 0;

        }

        public bool DeleteDepartment(int Depid)        //Delete Department from Department Table
        {
            
            var department = db.Departments.Find(Depid);
            
            if(department == null)
            {
                return false;
            }
            db.Remove(department);
            return db.SaveChanges() > 0;
        }

    }

    }

