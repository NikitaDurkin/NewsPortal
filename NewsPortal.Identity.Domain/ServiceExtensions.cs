using Microsoft.Extensions.DependencyInjection;
using NewsPortal.Identity.Domain.Interfaces;
using NewsPortal.Identity.Domain.Services;

namespace NewsPortal.Identity.Domain
{
    public static class ServicesExtensions
    {
        /// <summary>
        /// Добавление сервисов
        /// </summary>
        /// <param name="services">Сервисы</param>
        /// <returns></returns>
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}