using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrastructure.Repository.Abstract;
using SchoolProject.Infrastructure.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure
{
    public static class ModuleInfrastuctureDependancies
    {
        public static IServiceCollection AddInfrastructureDependancies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository,StudentRepository>();
            return services;
        }

    }
}
