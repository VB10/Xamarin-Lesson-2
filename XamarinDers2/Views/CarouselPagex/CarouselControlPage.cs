using System;

using Xamarin.Forms;

namespace XamarinDers2
{
	public class CarouselControlPage : CarouselPage
	{
		public CarouselControlPage()
		{
			Children.Add(new CPage1());
			Children.Add(new CPage2());
		}
	}
}

