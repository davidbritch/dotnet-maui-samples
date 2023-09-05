namespace MigrateProperties;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    async void OnButtonClicked(System.Object sender, System.EventArgs e)
    {
		// Xamarin.Essentials SecureStorage stores its data in AppInfo.PackageName.xamarinessentials
		// MAUI SecureStorage stores its data in AppInfo.PackageName.microsoft.maui.essentials.preferences
		// MAUI also uses different encryption for SecureStorage than used in Xamarin.Essentials (I think)

#if ANDROID || IOS
		string oauthToken = await SecureStorage.Default.GetAsync("oauth_token");
		if (oauthToken == null)
		{
			oauthToken = await LegacySecureStorage.GetAsync("oauth_token");
		}

		bool result = SecureStorage.Default.Remove("oauth_token");
		SecureStorage.Default.RemoveAll();

		result = LegacySecureStorage.Remove("oauth_token");
		LegacySecureStorage.RemoveAll();
#endif
	}
}
