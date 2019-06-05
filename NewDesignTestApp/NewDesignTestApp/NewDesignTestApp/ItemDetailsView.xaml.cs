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
	public partial class ItemDetailsView : ContentPage
	{
        public List<TutorialItem> TutorialItems { get; set; }

        public ItemDetailsView ()
		{
			InitializeComponent ();
            carousel.ItemsSource = TutorialItems = new List<TutorialItem>
            {
                new TutorialItem{ ImageUrl = "https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_W_Wool_Runner_Kotare_GREY_ANGLE_0f3bfe63-ac7d-4106-9acf-d26f8414ac53_600x600.png",Title="Puma", Subtitle="Puma Men's Sneakers" ,Text="Test"},
                new TutorialItem{ ImageUrl = "https://i1.wp.com/www.uniplanetstore.com/wp-content/uploads/2017/02/Tu-13-Dekh-Black-T-Shirt-Onlineindia-uniplanetstore.com_.jpg?fit=600%2C600",Title="Peter England", Subtitle="Men's weares", Text="Test data"},
                new TutorialItem{ ImageUrl = "http://backwoodzstudioz.com/wp-content/uploads/2017/08/Blockhead_FuneralBalloons_T-Shirt-MockUp_Front1_600-600x600.jpg",Title="Remand", Subtitle="Men's weares", Text="Test"},
                new TutorialItem{ ImageUrl = "http://pluspng.com/img-png/png-hd-pants--600.png",Title="Remand", Subtitle="Men's weares", Text="Test"},
                new TutorialItem{ ImageUrl = "https://www.dynafit.com/media/image/c2/c3/28/35f64a08-400b-40d5-b8e1-d6a1749596e7_dynafit_600x600.jpg",Title="Remand", Subtitle="Men's weares", Text="Test"},
                new TutorialItem{ ImageUrl = "https://4.imimg.com/data4/EV/CO/MY-12606452/1-500x500.jpg", Title="Remand", Subtitle="Men's weares", Text="Test Data"}
            };
        }
    }
}

public class TutorialItem
{
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Subtitle { get; set; }
    public string Text { get; set; }
}


