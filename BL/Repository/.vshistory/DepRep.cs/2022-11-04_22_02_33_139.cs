using adressBook.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adressBook.BL.Repository
{
    public class DepRep
    {
        public Department AddNewJob(Department dpt)
        {
            Department d = new Department();

            d.department = dpt.department;
            d.JobTitle = dpt.JobTitle;
            
        }
    }
}
