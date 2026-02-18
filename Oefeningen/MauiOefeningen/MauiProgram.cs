using Microsoft.Extensions.Logging;

namespace MauiOefeningen
{
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<NaamTonenPage>();
            builder.Services.AddSingleton<NaamTonenViewModel>();

            builder.Services.AddSingleton<VakPage>();
            builder.Services.AddSingleton<VakPageViewModel>();

            builder.Services.AddSingleton<AfbeeldingenPage>();
            builder.Services.AddSingleton<AfbeeldingViewModel>();

            return builder.Build();
        }
    }
}
