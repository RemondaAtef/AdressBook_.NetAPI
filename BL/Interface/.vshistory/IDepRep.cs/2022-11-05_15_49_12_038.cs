using adressBook.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adressBook.BL.Interface
{
    public interface IDepRep
    {
        Department AddNewJob(Department dpt);  //Add new job title or department
        public Department ViewDepByID(int? id);  //View Department by Department ID
        Department EditDepartment(int id, string dep, string job);      // Edit Job Title or Department in Department Table by Department ID
        public void DeleteDepartment(int Depid);            //Delete Department from Department Table
        
    }
}
