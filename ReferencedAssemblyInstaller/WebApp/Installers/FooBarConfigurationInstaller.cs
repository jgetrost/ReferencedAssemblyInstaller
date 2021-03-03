using Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Installers
{
    public class FooBarConfigurationInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            FooBarConfiguration _fooBarConfig = new FooBarConfiguration
            {
                FooBarCount = 7,
            };

            services.AddSingleton(_fooBarConfig);
        }
    }
}
