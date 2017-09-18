using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinDers2
{
	public partial class MessagePage1 : ContentPage
	{
		public MessagePage1()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{	

			Navigation.PushAsync(new MessagePage2());
			MessagingCenter.Send<MessagePage1, string>(this, "EntryValue", _enty.Text );

		}
	}
}
