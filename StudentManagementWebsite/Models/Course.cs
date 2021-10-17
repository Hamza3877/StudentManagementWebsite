using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentManagementWebsite.Models
{
    public partial class Course
    {
        public Course()
        {
            Registration = new HashSet<Registration>();
        }

        public int Id { get; set; }
        public string Course1 { get; set; }
        public int? Duration { get; set; }

        public virtual ICollection<Registration> Registration { get; set; }
    }
}
