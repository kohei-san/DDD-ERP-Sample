using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_ERP_Sample
{
    public static class ServiceCollectionExtensionsApplication
    {
        public static IServiceCollection AddApplications(
            this IServiceCollection services)
        {
            // Applicationサービスの登録
            services.AddScoped<Item.Application.Services.ItemApplicationService>();
            return services;
        }
    }
}
