using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Service.Abstract;
using SchoolProject.Service.Implemention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service
{
    public static class ModuleServiceDependancies
    {
        public static IServiceCollection AddStudentService(this IServiceCollection services)
        {
            services.AddTransient<IStudentService,StudentService>();
            return services;
        }
    }
}
