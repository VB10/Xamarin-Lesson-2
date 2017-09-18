using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinDers2
{
	public partial class MessagePage2 : ContentPage
	{
		public MessagePage2()
		{
			InitializeComponent();

			MessagingCenter.Subscribe<MessagePage1, string>(this, "EntryValue", (page, value) => {

				DisplayAlert("test", value, "ok");


				MessagingCenter.Unsubscribe<MessagePage1, string>(this, "EntryValue");
			
			});
		}
	}
}
