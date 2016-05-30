using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Pages;

namespace ConfDemo
{
	public partial class SessionPage : ListDataPage
	{
		public SessionPage()
		{
			InitializeComponent();
			Title = "Agenda";
		}
	}

	public class SessionDetailPage : DataPage
	{
		public SessionDetailPage()
		{
			((IDataSourceProvider)this).MaskKey("$id");
			((IDataSourceProvider)this).MaskKey("id");
			((IDataSourceProvider)this).MaskKey("hideTime");
			((IDataSourceProvider)this).MaskKey("evalUrl");
			((IDataSourceProvider)this).MaskKey("conferenceId");
			((IDataSourceProvider)this).MaskKey("roomId");

			SetBinding(TitleProperty, new DataSourceBinding("title"));
		}
	}
}

