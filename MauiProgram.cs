using MauiApp1.Views;
using Microsoft.Extensions.Logging;

namespace MauiApp1;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            }).ConfigureMauiHandlers((handlers) =>
            {
#if ANDROID
                handlers.AddHandler(typeof(Microsoft.Maui.Controls.Shell), typeof(MauiApp1.Platforms.Android.CustomTabRenderer));
#else
                handlers.AddHandler(typeof(Microsoft.Maui.Controls.Shell), typeof(MauiApp1.Platforms.iOS.CustomTabRenderer));
#endif
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddTransient<CatsPage>();
        builder.Services.AddTransient<ViewModels.CatsViewModel>();

        builder.Services.AddTransient<CatsDetailsPage>();
        builder.Services.AddTransient<ViewModels.CatsDetailsViewModel>();

        builder.Services.AddTransient<DogsPage>();

        Routing.RegisterRoute("CatsDetailsPage", typeof(CatsDetailsPage));

        return builder.Build();
    }
}
