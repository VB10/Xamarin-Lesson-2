using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinDers2.Droid;

[assembly : ExportRenderer(typeof(Label),typeof(LabelCustomRenderer) )]
namespace XamarinDers2.Droid
{
	public class LabelCustomRenderer : LabelRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Label> e)
		{
			base.OnElementChanged(e);
			if (Control==null)
			{
				return;
			}

			Control.SetBackgroundColor(Android.Graphics.Color.Azure);
			Control.Text = "Hardwareandro Android !";
			Control.SetTextColor(Android.Graphics.Color.Black);
		}
	}
}
