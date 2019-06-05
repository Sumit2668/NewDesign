using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NewDesignTestApp.AnimationTrigger
{
    public class ValidateImage : Image
    {
        static readonly BindablePropertyKey IsValidPropertyKey = 
            BindableProperty.CreateReadOnly("IsValid", typeof(bool), typeof(ValidateImage), false);
        public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

        public bool IsValid
        {
            get { return (bool)base.GetValue(IsValidProperty); }
            private set { base.SetValue(IsValidPropertyKey, value); }
        }

        //protected override void OnAttachedTo(Entry bindable)
        //{
        //    bindable.TextChanged += HandleTextChanged;
        //    bindable.Unfocused += Bindable_Unfocused;
        //}

        //private void Bindable_Unfocused(object sender, FocusEventArgs e)
        //{
        //    //IsValid = !string.IsNullOrWhiteSpace(((Entry)sender).Text);
        //    //((Entry)sender).TextColor = IsValid ? (Color)Application.Current.Resources["BlueColor"] : Color.Red;
        //}

        //void HandleTextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(((Entry)sender).Text))
        //    {
        //        ((Entry)sender).Text = char.ToUpper(((Entry)sender).Text[0]) + ((Entry)sender).Text.Substring(1);
        //    }
        //    //IsValid = !string.IsNullOrWhiteSpace(e.NewTextValue);
        //    //((Entry)sender).TextColor = IsValid ? (Color)Application.Current.Resources["BlueColor"] : Color.Red;
        //}

        //protected override void OnDetachingFrom(Entry bindable)
        //{
        //    bindable.TextChanged -= HandleTextChanged;
        //    bindable.Unfocused -= Bindable_Unfocused;
        //}
    }
}
