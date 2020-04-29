using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Repositories.Implements
{

    public class StudentRepository: GenericRepository<Student> , IStudentRepository
    {
        private SchoolContext schoolContext;
        public StudentRepository(SchoolContext schoolContext) : base(schoolContext)
        {
            this.schoolContext = schoolContext;
        }

        
        public Task<IEnumerable<Course>> GetCourseByStudent(int id)
        {
            var listCourses = await(from enrollment in schoolContext.Enrollments
                                   join course in schoolContext.Courses on enrollment.CourseID equals course.ID
                                   where enrollment.StudentID == id
                                   select course).ToListAsync();
            return listCourses;
        }
        public new async Task Delete(int id)
        {
            var entity = await GetById(id);

            if (entity == null)

                throw new Exception("The entity  is null");
            var flag = schoolContext.Enrollments.Any(x => x.CourseID == id);
            if (flag)
                throw new Exception("the course have Enrolments");
            schoolContext.Courses.Remove(entity);
            await schoolContext.SaveChangesAsync();
        }

    }
}
