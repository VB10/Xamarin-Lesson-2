using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;

namespace XamarinDers2
{
	public partial class HomeXPage : ContentPage
	{
		public HomeXPage()
		{
			InitializeComponent();
		}

		public void Handle_Clicked(object sender, EventArgs e)
		{
			var data = new Quest
			{
				questions = "xamarin candır",
				answ1 = "evet",
				answ2 = "hayır"
			};


			Navigation.PushPopupAsync(new MyPopupPage());
			MessagingCenter.Send<HomeXPage, Quest>(this, "Questions", data);

		}
	}
}
