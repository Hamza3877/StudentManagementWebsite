using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentManagementWebsite.Models
{
    public partial class Registration
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Nic { get; set; }
        public int? CourseId { get; set; }
        public int? BatchId { get; set; }
        public int? Tellno { get; set; }

        public virtual Batch Batch { get; set; }
        public virtual Course Course { get; set; }
    }
}
