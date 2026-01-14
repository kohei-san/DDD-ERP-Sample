using DDD_ERP_Sample.Forms.Item;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_ERP_Sample
{
    public static class ServiceCollectionExtensionsForm
    {
        public static IServiceCollection AddForms(
            this IServiceCollection services)
        {
            // Formサービスの登録
            services.AddScoped<MainMenuForm>();
            services.AddScoped<ItemMenuForm>();
            services.AddScoped<Forms.Item.ItemMasterRegisterForm>();
            return services;
        }

    }
}
