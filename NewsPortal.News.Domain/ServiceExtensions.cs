using Microsoft.Extensions.DependencyInjection;
using NewsPortal.News.Domain.Interfaces;
using NewsPortal.News.Domain.Services;

namespace NewsPortal.News.Domain
{
    public static class ServiceExtensions
    {
        /// <summary>
        /// Добавление сервисов
        /// </summary>
        /// <param name="services">Сервисы</param>
        /// <returns></returns>
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddScoped<IPublicationsService, PublicationsService>();
            return services;
        }
    }
}