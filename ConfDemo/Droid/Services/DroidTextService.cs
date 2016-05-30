using System;
using Xamarin.Forms;
[assembly: Xamarin.Forms.Dependency(typeof(ConfDemo.Droid.DroidTextService))]
namespace ConfDemo.Droid
{
	public class DroidTextService : ITextService
	{
		public string GetHeader()
		{
			return "Hei fra Android";
		}
	}

}