using adressBook.BL.Interface;
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

        public Department ViewDepByID(int? id)               //View Department by Department ID
        {
            var data = db.Departments.Find(id);

            return data;
        }

        public Department EditDepartment(int id, string dep, string job)         // Edit Job Title or Department in Department Table by Department ID
        {           

            var data = ViewDepByID(id);
                     

            if (dep != null && job != null)        // when I entered departemnt and job title, system will update them 
            {
                data.department = dep;
                data.JobTitle = job;             
            }
            else if(dep == null && job != null)    // when I entered the job title only, the system will update the job
            {
                data.JobTitle = job;
            }
            else if (dep != null && job == null)  // when I entered department only , system will department
            {
                data.department = dep;
            }

            db.Departments.Update(data);
            db.SaveChanges();

            return data;
        }

        public void DeleteDepartment(int Depid)        //Delete Department from Department Table
        {
            Department department;

            department = db.Departments.Where(a => a.DepID == Depid)
                                            .FirstOrDefault();

            db.Departments.Remove(department);
            db.SaveChanges();
        }

                

    }
}
