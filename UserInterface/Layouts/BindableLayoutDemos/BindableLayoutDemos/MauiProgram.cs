namespace BindableLayoutDemos;

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
				fonts.AddFont("ionicons.ttf", "Ionicons");
				fonts.AddFont("fa-solid-900.ttf", "fa-solid-900");
			});

		return builder.Build();
	}
}
