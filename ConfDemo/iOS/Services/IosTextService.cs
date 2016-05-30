using System;
[assembly:Xamarin.Forms.Dependency(typeof(ConfDemo.iOS.IosTextService))]
namespace ConfDemo.iOS
{
	public class IosTextService : ITextService
	{
		public string GetHeader()
		{
			return "Hei fra iOS";
		}
	}
}

