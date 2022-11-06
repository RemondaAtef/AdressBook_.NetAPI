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
    }
}
