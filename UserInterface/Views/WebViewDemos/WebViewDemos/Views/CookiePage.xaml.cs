using System.Net;

namespace WebViewDemos;

public partial class CookiePage : ContentPage
{
	public CookiePage()
	{
		InitializeComponent();

		CookieContainer cookieContainer = new CookieContainer();
		Uri uri = new Uri("https://docs.microsoft.com/dotnet/maui", UriKind.RelativeOrAbsolute);

		Cookie cookie = new Cookie
		{
			Name = "DotNetMauiCookie",
			Expires = DateTime.Now.AddDays(1),
			Value = "My cookie",
			Domain = uri.Host,
			Path = "/"
		};
		cookieContainer.Add(cookie);
		webView.Cookies = cookieContainer;
		webView.Source = new UrlWebViewSource
		{
			Url = uri.ToString()
		};
	}
}