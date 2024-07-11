using ChessMAUI.Views;
using Microsoft.Extensions.Logging;
using Plugin.Maui.Audio;
using CommunityToolkit.Maui;

namespace ChessMAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiCommunityToolkitMediaElement()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }); 

            builder.Services.AddSingleton(AudioManager.Current);
            builder.Services.AddTransient<Home>();
            builder.Services.AddTransient<Credits>();
            builder.Services.AddTransient<GameBoard>();
            builder.Services.AddTransient<PlayerCreation>();
            builder.Services.AddTransient<PlayerSelection>();
            builder.Services.AddTransient<Preselection>();
            builder.Services.AddTransient<ScoreBoard>();
            builder.Services.AddTransient<Setting>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
