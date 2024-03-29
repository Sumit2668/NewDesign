﻿using NewDesignTestApp.CustomControls;
using NewDesignTestApp.iOS.Renderers;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace NewDesignTestApp.iOS.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Control.Layer.BorderWidth = 0;
            Control.BorderStyle = UITextBorderStyle.None;

            //Control.BackgroundColor = UIColor.Clear;
            //Control.Layer.BorderWidth = 0;
            //Control.BorderStyle = UITextBorderStyle.None;
            //Control.AutocapitalizationType = UITextAutocapitalizationType.None; // No Autocapitalization
            //Control.TextAlignment = UITextAlignment.Left;
        }
    }
}