﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Services
{
    internal static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            return services
           .AddTransient<IDataService, DataService>()
           .AddTransient<IUserDialog, UserDialog>();
        } 
    }
}
