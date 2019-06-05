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
	public partial class EmptyViewFilteredPage : ContentPage
	{
		public EmptyViewFilteredPage ()
		{
			InitializeComponent ();
            BindingContext = new MonkeysViewModel();
        }
	}
}