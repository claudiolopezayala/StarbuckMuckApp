﻿using Microsoft.Extensions.Logging;

namespace TDMPW_411_2P_EX;

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
				fonts.AddFont("SoDoSans-Regular.ttf", "CoffeCake");
				fonts.AddFont("fontello.ttf", "Iconos");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

        return builder.Build();
	}
}
