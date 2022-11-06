using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace adressBook.DAL.Entities
{
    public class Department
    {
        [Key]
        public int DepID { get; set; }

        public string JobTitle { get; set; }

        public string department { get; set; }

        public int ID { get; set; }
        [ForeignKey("ID")]
        public virtual ContactPerson ContactPerson { get; set; }
    }
}
