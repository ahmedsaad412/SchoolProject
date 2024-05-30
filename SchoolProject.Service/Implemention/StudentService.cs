using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Repository.Abstract;
using SchoolProject.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Implemention
{
    public class StudentService :IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
           _studentRepository = studentRepository;
        }
        

        public Task<List<Student>> GetAllAsync()
        {
            var students = _studentRepository.GetAllAsync();
            return students;
        }
    }
}
