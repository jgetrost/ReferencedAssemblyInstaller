using Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace WebApp.Installers
{
    public static class InstallerExtensions
    {
        public static void InstallServicesAcrossAssemblies(this IServiceCollection services, IConfiguration configuration)
        {
            Assembly _assembly = typeof(Startup).Assembly;

            AssemblyName[] _referencedAssemblies = _assembly.GetReferencedAssemblies();

            List<IInstaller> _installers = new List<IInstaller>();

            _installers.AddRange(typeof(Startup).Assembly.ExportedTypes.Where(x =>
                typeof(IInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).Select(Activator.CreateInstance).Cast<IInstaller>().ToList());

            foreach(AssemblyName _referencedAssembly in _referencedAssemblies)
            {
                _installers.AddRange(Assembly.Load(_referencedAssembly).ExportedTypes.Where(t => typeof(IInstaller).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract).Select(Activator.CreateInstance).Cast<IInstaller>().ToList());
            }

            _installers.ForEach(i => i.InstallServices(services, configuration));
        }
    }
}
