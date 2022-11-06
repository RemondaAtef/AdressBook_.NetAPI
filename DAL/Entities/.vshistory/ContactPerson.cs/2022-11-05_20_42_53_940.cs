using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace adressBook.DAL.Entities
{
    public class ContactPerson
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Name Cannot exceed 40 characters")]
        public string FullName { get; set; }

        
        [DataType(DataType.PhoneNumber)]
        public string MobileNo { get; set; }

        public string HomeTelNo { get; set; }

        [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }

        public string Address { get; set; }

        
        [EmailAddress(ErrorMessage = "You Must Enter Valid Mail")]
        public string Email { get; set; }

        public string Photo { get; set; }

        public int DepID { get; set; }
        [ForeignKey("DepID")]
        public virtual Department Department { get; set; }
    }
}
