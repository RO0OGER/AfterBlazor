using Microsoft.Extensions.Logging;
using Supabase;

namespace After
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            
            var url = "https://bflnjiakxwfuiissjgos.supabase.co";  
            var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImJmbG5qaWFreHdmdWlpc3NqZ29zIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MzQ1OTQwMzEsImV4cCI6MjA1MDE3MDAzMX0.RWGO7Ylo_poQqPa0tCkPpFJM1cCM92RMyY8MKulrm3k";  // Replace with your actual API key

            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(key))
            {
                throw new InvalidOperationException("Supabase URL and Key must be provided.");
            }

            var options = new SupabaseOptions
            {
                AutoRefreshToken = true,
                AutoConnectRealtime = true,
            };

            builder.Services.AddSingleton(provider => new Supabase.Client(url, key, options));

            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
