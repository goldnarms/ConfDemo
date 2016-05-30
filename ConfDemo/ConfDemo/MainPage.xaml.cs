using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConfDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			Title = "Hovedside";
			var textService = DependencyService.Get<ITextService>(DependencyFetchTarget.NewInstance);
			BindingContext = new { Header = textService.GetHeader() };
		}
	}
}

