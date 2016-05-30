using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Should;

namespace ConfDemo.UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class LogingPageTests
	{
		IApp app;
		Platform platform;

		public LogingPageTests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void Welcome_text_be_displayed()
		{
			AppResult[] results = app.WaitForElement(c => c.Marked("Velkommen!"));
			app.Screenshot("Welcome screen.");

			results.Any().ShouldBeTrue();
		}

		[Test]
		public void Login_should_take_us_to_MainPage()
		{
			app.Tap(c => c.Marked("Logg inn"));
			if (platform == Platform.Android)
			{
				app.WaitForElement(c => c.Marked("Hei fra Android")).Any().ShouldBeTrue();
			}
			else if (platform == Platform.iOS)
			{
				app.WaitForElement(c => c.Marked("Hei fra iOS")).Any().ShouldBeTrue();
			}
		}
	}
}

