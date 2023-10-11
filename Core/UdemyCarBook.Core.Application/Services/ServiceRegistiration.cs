using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Core.Application.Services
{
    public static class ServiceRegistiration
    {
        public static void AddApplicationServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(ServiceRegistiration).Assembly));
        }
    }
}
