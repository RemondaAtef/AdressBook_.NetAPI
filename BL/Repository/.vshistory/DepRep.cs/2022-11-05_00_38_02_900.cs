﻿using adressBook.BL.Interface;
using adressBook.DAL.Database;
using adressBook.DAL.Entities;
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
            Department d = new Department();

            d.department = dpt.department;
            d.JobTitle = dpt.JobTitle;

            db.Departments.Add(d);
            db.SaveChanges();

            return dpt;
        }

        public Department EditDepartment(int id, string dep, string job)         // Edit Job Title or Department in Department Table by Department ID
        {
            var data = db.Departments.Where(a => a.DepID == id)
                                   .Select(a => new Department() { DepID = a.DepID, department = a.department, JobTitle = a.JobTitle })
                                   .FirstOrDefault();

            if(dep != null && job != null)
            {
                data.department = dep;
                data.JobTitle = job;             
            }
            else if(dep == null && job != null)
            {
                data.JobTitle = job;
            }
            else if (dep != null && job == null)
            {
                data.department = dep;
            }

            db.Departments.Update(data);
            db.SaveChanges();

            return data;
        }

        
    }
}
