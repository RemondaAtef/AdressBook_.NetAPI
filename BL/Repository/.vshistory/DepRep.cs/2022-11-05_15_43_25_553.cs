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

        public Department ViewDepByID(int? id)
        {
            var data = db.Departments.Find(id);

            return data;
        }

        public Department EditDepartment(int id, string dep, string job)         // Edit Job Title or Department in Department Table by Department ID
        {
            //var data = db.Departments.Where(a => a.DepID == id)                 // search with department id which i entered in  
            //                         .Select(a => new Department() { DepID = a.DepID, department = a.department, JobTitle = a.JobTitle })
            //                         .FirstOrDefault();

            var data = ViewDepByID(id);

            data.department = data.department;
            data.JobTitle = data.JobTitle;

            if (dep != null && job != null)        // when i entered departemnt and job title, system will update them 
            {
                data.department = dep;
                data.JobTitle = job;             
            }
            else if(dep == null && job != null)    // when i entered job title only , system will update job
            {
                data.JobTitle = job;
            }
            else if (dep != null && job == null)  // when i entered department only , system will department
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
