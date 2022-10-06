using Microsoft.Maui.Controls;

namespace ContextMenuDemo;

public partial class MainPage : ContentPage
{
	int counter;
	public string Counter => counter.ToString();

	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
	}

	void OnPauseClicked(object sender, EventArgs e)
	{

	}

	void OnStopClicked(object sender, EventArgs e)
	{

	}

	void OnLabelClicked(object sender, EventArgs e)
	{
		MenuFlyoutItem menuItem = sender as MenuFlyoutItem;
		string color = menuItem.CommandParameter as string;
		label.TextColor = Color.Parse(color);
	}

	void OnEntryBoldClicked(object sender, EventArgs e)
	{
		entry.FontAttributes = FontAttributes.Bold;
	}

	void OnEntryItalicClicked(object sender, EventArgs e)
	{
		entry.FontAttributes = FontAttributes.Italic;
	}

	void OnEntryNoneClicked(object sender, EventArgs e)
	{
		entry.FontAttributes = FontAttributes.None;
	}

	void OnButtonClicked(object sender, EventArgs e)
	{
		counter++;
		OnPropertyChanged(nameof(Counter));
	}

	void OnIncrementMenuItemClicked(object sender, EventArgs e)
	{
		MenuFlyoutItem menuItem = sender as MenuFlyoutItem;
		int amount = int.Parse((string)menuItem.CommandParameter);
		counter += amount;
		OnPropertyChanged(nameof(Counter));
	}

	void OnAddMenuItemClicked(object sender, EventArgs e)
	{
		MenuFlyout menu = ((MenuFlyoutItem)sender).Parent as MenuFlyout;
		menu.Add(new MenuFlyoutItem
		{
			Text = "Menu item added at runtime"
		});
	}

	void OnAddSubMenuItemClicked(object sender, EventArgs e)
	{
		MenuFlyoutSubItem subMenu = sender as MenuFlyoutSubItem;
		subMenu.Add(new MenuFlyoutItem
		{
			Text = "Menu item added at runtime"
		});
	}

	void OnWebViewGoToRepoClicked(object sender, EventArgs e)
	{
		MenuFlyoutItem menuItem = sender as MenuFlyoutItem;
		string repo = menuItem.CommandParameter as string;
		string url = repo == "docs" ? "docs-maui" : "maui";
		webView.Source = new UrlWebViewSource { Url = $"https://github.com/dotnet/{url}" };
	}
}

