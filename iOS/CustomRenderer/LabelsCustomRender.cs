using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinDers2.iOS;

[assembly : ExportRenderer(typeof(Label), typeof(LabelsCustomRender))]
namespace XamarinDers2.iOS
{
	public class LabelsCustomRender : LabelRenderer
	{
		
		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Label> e)
		{
			base.OnElementChanged(e);

			if (Control==null)
			{
				return;
			}

			Control.BackgroundColor = UIKit.UIColor.Cyan;
			Control.Text = "Hardwareandro iOS!";
			Control.TextColor = UIKit.UIColor.Green;


		}
	}
}
