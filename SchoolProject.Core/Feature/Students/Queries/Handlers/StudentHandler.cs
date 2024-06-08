using MediatR;
using SchoolProject.Core.Feature.Students.Queries.Models;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Feature.Students.Queries.Handlers
{
    
    public class StudentHandler : IRequestHandler<GetStudentListQuery, List<Student>>
    {
        private readonly IStudentService _studentService;

        public StudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }
       
        public async Task<List<Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return await _studentService.GetAllAsync();
        }
    }
}
