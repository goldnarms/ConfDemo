using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConfDemo
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new LoginPage());
		}
	}
}

