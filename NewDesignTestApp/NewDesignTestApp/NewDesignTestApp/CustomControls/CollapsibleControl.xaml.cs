using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewDesignTestApp.CustomControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CollapsibleControl : ContentView
	{
		public CollapsibleControl ()
		{
			InitializeComponent ();
            secondText.IsVisible = false;
            imgUpDown.Source = "downarrow.png";
        }

        public string FirstText
        {
            get { return base.GetValue(FirstTextProperty).ToString(); }
            set { base.SetValue(FirstTextProperty, value); }
        }

        private static void FirstTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CollapsibleControl)bindable;
            control.firstText.Text = newValue.ToString();
        }
        private static BindableProperty FirstTextProperty = BindableProperty.Create(propertyName: "FirstText", returnType: typeof(string), declaringType: typeof(CollapsibleControl), defaultValue: "", defaultBindingMode: BindingMode.TwoWay, propertyChanged: FirstTextPropertyChanged);



        public string SecondText
        {
            get { return base.GetValue(SecondTextProperty).ToString(); }
            set { base.SetValue(SecondTextProperty, value); }
        }

        private static BindableProperty SecondTextProperty = BindableProperty.Create(
                                                         propertyName: "SecondText",
                                                         returnType: typeof(string),
                                                         declaringType: typeof(CollapsibleControl),
                                                         defaultValue: "",
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: SecondTextPropertyChanged);


        private static void SecondTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CollapsibleControl)bindable;
            control.secondText.Text = newValue.ToString();
        }


        public static BindableProperty ImageProperty = BindableProperty.Create(
                                                        propertyName: "Image",
                                                        returnType: typeof(string),
                                                        declaringType: typeof(CollapsibleControl),
                                                        defaultValue: "",
                                                        defaultBindingMode: BindingMode.TwoWay,
                                                        propertyChanged: ImageSourcePropertyChanged);

        public string Image
        {
            get { return base.GetValue(ImageProperty).ToString(); }
            set { base.SetValue(ImageProperty, value); }
        }

        private static void ImageSourcePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CollapsibleControl)bindable;
            control.imgUpDown.Source = ImageSource.FromFile(newValue.ToString());
        }


        public bool EditorVisible
        {
            get { return (bool)base.GetValue(EditorVisibleProperty); }
            set { base.SetValue(EditorVisibleProperty, value); }
        }
        private static void EditorVisiblePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CollapsibleControl)bindable;
            control.secondText.IsVisible = (bool)newValue;
        }
        public static BindableProperty EditorVisibleProperty = BindableProperty.Create(
                                                     propertyName: "EditorVisible",
                                                     returnType: typeof(bool),
                                                     declaringType: typeof(CollapsibleControl),
                                                     defaultValue: false,
                                                     defaultBindingMode: BindingMode.TwoWay,
                                                     propertyChanged: EditorVisiblePropertyChanged);



    

        private void Genral_Tapped(object sender, EventArgs e)
        {
            var control = ((Grid)sender);
            var ce = control.Children[2] as Label;
            var img = control.Children[1] as Image;
            ce.IsVisible = !ce.IsVisible;
            FileImageSource source = (FileImageSource)(img).Source;
            img.Source = source.File == "uparrow.png" ? "downarrow.png" : "uparrow.png";
            if (source.File == "downarrow.png")
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    ce.Focus();
                });
            }
        }

    }
}