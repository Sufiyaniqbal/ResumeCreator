using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeCreator.Models
{
    public class ViewModel
    {   
        public PersonalDetails personalDetails { get; set; }
        public EducationDetails educationDetails{ get; set; }
        public ExperienceDetails experienceDetails { get; set; }
    }
}