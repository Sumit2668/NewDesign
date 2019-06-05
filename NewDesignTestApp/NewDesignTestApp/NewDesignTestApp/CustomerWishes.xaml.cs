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
	public partial class CustomerWishes : ContentPage
	{
		public CustomerWishes ()
		{
			InitializeComponent ();
            //BindingContext = new MonkeysViewModel();
            MonkeysViewModel viewModel = new MonkeysViewModel();
            BindingContext = viewModel;

            collectionView.SelectedItems.Add(viewModel.Stores.Skip(1).FirstOrDefault());
            collectionView.SelectedItems.Add(viewModel.Stores.Skip(3).FirstOrDefault());
            collectionView.SelectedItems.Add(viewModel.Stores.Skip(4).FirstOrDefault());
        }
	}
}