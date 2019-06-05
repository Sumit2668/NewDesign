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
	public partial class NaavigationView : ContentPage
	{
		public NaavigationView ()
		{
			InitializeComponent ();
		}

        private void Wishes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyWishesView());
        }

        private void Stores_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void CustWishes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomerWishes());
        }

        private void Notification_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NotificationView());
        }

        private void Itemdetails_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ItemDetailsView());
        }
    }
}