using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDependency(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblies([typeof(ApplicationAssembly).Assembly]);
            return services;
        }
    }
}
