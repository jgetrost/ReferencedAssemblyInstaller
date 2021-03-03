using Core;
using Foo.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Foo
{
    public class FooInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            FooService _fooService = new FooService();
            services.AddSingleton(_fooService);
        }
    }
}