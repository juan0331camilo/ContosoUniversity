using ContosoUniversity.Data;
using ContosoUniversity.Models;
using ContosoUniversity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Services.Implements
{
    public class EnrollmentService : GenericService<Enrollment>, IEnrollmentService

    {
        public EnrollmentService(IEnrollmentRepository enrollmentRepository) : base(enrollmentRepository)
        {


        }
    }
}
