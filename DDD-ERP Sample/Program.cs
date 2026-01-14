using DDD_ERP_Sample.Forms.Item;
using Item.Application.Services;
using Item.Domain.Repositories;
using Item.Infrastracture.Db;
using Item.Infrastracture.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DDD_ERP_Sample
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var config = new ConfigurationBuilder()
                            .AddJsonFile("appSetting.json")
                            .Build();

            var connectionString = config.GetConnectionString("Default");


            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Repository ‚ð DI ‚É“o˜^
            services.AddScoped<IUnitMasterRepository, UnitMasterRepository>();
            //services.AddScoped<IItemMasterRepository, ItemMasterRepository>();
            //services.AddScoped<IItemTypeMasterRepository, ItemTypeMasterRepository>();

            // ApplicationService ‚ð DI ‚É“o˜^
            services.AddScoped<ItemApplicationService>();

            // Form ‚à DI ‚É“o˜^
            services.AddScoped<MainMenuForm>();
            services.AddScoped<ItemMenuForm>();
            services.AddScoped<Forms.Item.ItemMasterRegisterForm>();

            var provider = services.BuildServiceProvider();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(provider.GetRequiredService<MainMenuForm>());
        }
    }
}