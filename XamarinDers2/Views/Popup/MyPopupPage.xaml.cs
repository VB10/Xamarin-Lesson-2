using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Extensions;

using Xamarin.Forms;

namespace XamarinDers2
{
	public partial class MyPopupPage : PopupPage
	{
		public MyPopupPage()
		{
			InitializeComponent();

			MessagingCenter.Subscribe<HomeXPage, Quest>(this, "Questions", (page, data) => {

				_lblQuest.Text = data.questions;
				_lblans1.Text = data.answ1;
				_lblans2.Text = data.answ2;
			
			});
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopPopupAsync();
		}
	}
}
