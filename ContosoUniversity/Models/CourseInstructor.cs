using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public partial class CourseInstructor
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public int InstructorID { get; set; }

        public virtual Course Course { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}
