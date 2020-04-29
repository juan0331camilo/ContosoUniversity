using ContosoUniversity.Models;
using ContosoUniversity.Services.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Services
{
    public interface IStudentService : IGenericService<Student>
    {
        Task<IEnumerable<Course>> GetCourseByStudent(int id);
    }
}