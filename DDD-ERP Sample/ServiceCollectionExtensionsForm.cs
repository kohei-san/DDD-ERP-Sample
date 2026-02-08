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
            // Transient: 毎回新しいインスタンスを生成で登録する　→　Scopedの場合、閉じて再度開こうとすると破棄済みのインスタンスを参照しようとして例外が発生する
            services.AddTransient<MainMenuForm>();
            services.AddTransient<ItemMenuForm>();
            services.AddTransient<Forms.Item.ItemMasterRegisterForm>();
            return services;
        }

    }
}
