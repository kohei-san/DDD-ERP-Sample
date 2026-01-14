using Item.Domain.Repositories;
using Item.Infrastracture.Db;
using Item.Infrastracture.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_ERP_Sample
{
    public static class ServiceCollectionExtensionsInfrastructure
    {
        public static IServiceCollection AddInfrastructures(
            this IServiceCollection services,
            string connectionString)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IUnitMasterRepository, UnitMasterRepository>();
            //services.AddScoped<IItemMasterRepository, ItemMasterRepository>();
            //services.AddScoped<IItemTypeMasterRepository, ItemTypeMasterRepository>();

            return services;
        }
    }
}
