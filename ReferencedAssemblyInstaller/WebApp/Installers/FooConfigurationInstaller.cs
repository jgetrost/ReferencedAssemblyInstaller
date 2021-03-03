using Core;
using Foo;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Installers
{
    public class FooConfigurationInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            FooConfig _fooConfig = new FooConfig
            {
                Foo = "Foooooo",
            };

            // private repo behind service

            services.AddSingleton(_fooConfig);
        }
    }
}
