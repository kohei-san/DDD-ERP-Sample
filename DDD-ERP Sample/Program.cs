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

            // DI‚Ì“o˜^
            services.AddInfrastructures(connectionString);
            services.AddApplications();
            services.AddForms();

            var provider = services.BuildServiceProvider();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(provider.GetRequiredService<MainMenuForm>());
        }
    }
}