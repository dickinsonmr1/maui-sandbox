namespace MauiSandboxApp;

public class TestPage : ContentPage
{
	public TestPage()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI! You're welcome :)"
				}
			}
		};
	}
}