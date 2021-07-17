using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Plugin.CustomPoint.ManageCustom.Factories;
using Nop.Plugin.CustomPoint.ManageCustom.Services;

namespace Nop.Plugin.CustomPoint.ManageCustom.Infrastructure
{
    /// <summary>
    /// Dependency registrar
    /// </summary>
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(IServiceCollection services, ITypeFinder typeFinder, AppSettings appSettings)
        {
            services.AddScoped<IManageCustomService, ManageCustomService>();
            services.AddScoped<IManageCustomModelFactory, ManageCustomModelFactory>();
        }
        public int Order => 1;
    }
}