using CoreGraphics;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Unibikers.App.iOS.Models.Custom;
using Unibikers.App.Models.Custom;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundedEntry), typeof(RoundedEntryRenderIoS))]
namespace Unibikers.App.iOS.Models.Custom
{
    public class RoundedEntryRenderIoS : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.Layer.CornerRadius = 2;
                Control.Layer.BorderWidth = 2f;
                Control.Layer.BorderColor = Color.Teal.ToCGColor();
                Control.Layer.BackgroundColor = Color.Snow.ToCGColor();

                Control.LeftView = new UIKit.UIView(new CGRect(0, 0, 10, 0));
                Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;
            }
        }
    }
}