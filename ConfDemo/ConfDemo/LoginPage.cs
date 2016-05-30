using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConfDemo
{
	public class LoginPage : ContentPage
	{
		public LoginPage()
		{
			var label = new Label { Text = "Velkommen!", FontSize = Device.OnPlatform(20, 30, 20) };
			var loginEntry = new Button { Text = "Logg inn" };
			loginEntry.Clicked += async (sender, e) => await GoToMain(sender, e);
			var stackLayout = new StackLayout();
			stackLayout.Children.Add(label);
			stackLayout.Children.Add(loginEntry);
			stackLayout.HorizontalOptions = LayoutOptions.CenterAndExpand;
			stackLayout.VerticalOptions = LayoutOptions.CenterAndExpand;

			Content = stackLayout;
		}

		private async Task GoToMain(object sender, EventArgs e)
		{
			var tabbedPage = new TabbedPage();
			tabbedPage.Children.Add(new MainPage());
			tabbedPage.Children.Add(new SessionPage());
			await Navigation.PushAsync(tabbedPage);
		}
	}
}