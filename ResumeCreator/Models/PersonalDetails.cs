﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeCreator.Models
{
        public class PersonalDetails
        {
            public string Name { get; set; }
            public DateTime DOB { get; set; }
            public string Country { get; set; }
            public string Address { get; set; }
            public string State { get; set; }
            public string City { get; set; }
            public string ZipCode { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }

        }
}