using ContosoUniversity.Models;
using ContosoUniversity.Services.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Services
{
    public interface ICourseService : IGenericService<Course>
    {
        Task<IEnumerable<Student>> GetStudentsByCourse(int id);
    }
}
