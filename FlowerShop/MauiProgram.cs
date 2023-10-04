using CommunityToolkit.Maui;
using FlowerShop.Pages;
using FlowerShop.Services;
using FlowerShop.ViewModels;
using Microsoft.Extensions.Logging;

namespace FlowerShop
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif
            AddFlowersServices(builder.Services);
            return builder.Build();
        }
        private static IServiceCollection AddFlowersServices(IServiceCollection services)
        {
            services.AddSingleton<FlowerService>();
            services.AddSingletonWithShellRoute<HomePage, HomeViewModel>(nameof(HomePage));
            return services;
        }
    }
}