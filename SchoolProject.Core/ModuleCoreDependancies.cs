using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrastructure.Repository.Abstract;
using SchoolProject.Infrastructure.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core
{
    public static class ModuleCoreDependancies
    {
        public static IServiceCollection AddCoreDependancies(this IServiceCollection services)
        {
            services.AddMediatR(r => r.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}