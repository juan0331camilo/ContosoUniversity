using ContosoUniversity.Models;
using ContosoUniversity.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContosoUniversity.Services.Implements
{
    public class StudentService : GenericService<Student>, IStudentService

    {
        private IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository) : base(studentRepository)
        {

            this.studentRepository = studentRepository;
        }

        public Task<IEnumerable<Course>> GetCourseByStudent(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Course>> GetCoursesByStudent(int id)
        {
            return await studentRepository.GetCoursesByStudent(id);
        }

    }

}