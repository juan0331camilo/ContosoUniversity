﻿using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public partial class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public decimal? Budget { get; set; }
        public DateTime? StartDate { get; set; }
        public int? InstructorID { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}
