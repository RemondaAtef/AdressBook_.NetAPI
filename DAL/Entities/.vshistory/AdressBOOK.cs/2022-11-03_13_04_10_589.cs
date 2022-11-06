﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace adressBook.DAL.Entities
{
    public class AdressBOOK
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Name Cannot exceed 40 characters")]
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string MobileNo { get; set; }
        public string HomeTelNo { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string GPSlocation { get; set; }

    }
}
