using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adressBook.DAL.ViewModels
{
    public class ViewUserVM
    {
        public string FullName { get; set; }
        public string MobileNo { get; set; }
        public string HomeTelNo { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
    }
}
