using NewDesignTestApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewDesignTestApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyWishesView : ContentPage
	{
		public MyWishesView ()
		{
			InitializeComponent ();
            BindingContext = new MonkeysViewModel();
        }
	}
}