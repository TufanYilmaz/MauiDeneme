using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.Extensions.Logging;

namespace MauiDeneme
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
			builder.Services.AddSingleton<IAuth, Auth>();
			builder.Services.AddTransient<LandingPage>();
			builder.Services.AddTransient<MainPage>();
#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
