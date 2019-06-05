using NewDesignTestApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewDesignTestApp
{
    public partial class MainPage : ContentPage
    {
        public List<Store> storelist;
        public MainPage()
        {
            try
            {

           
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
            storelist = new List<Store>();
            storelist.Add(new Store() { Id = 1, ImageUrl = "https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_W_Wool_Runner_Kotare_GREY_ANGLE_0f3bfe63-ac7d-4106-9acf-d26f8414ac53_600x600.png", IsLike = true, Price = 21.00, Title = "Title" });
            storelist.Add(new Store() { Id = 2, ImageUrl = "https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_W_Wool_Runner_Kotare_GREY_ANGLE_0f3bfe63-ac7d-4106-9acf-d26f8414ac53_600x600.png", IsLike = true, Price = 88.12, Title = "Title" });
            storelist.Add(new Store() { Id = 3, ImageUrl = "https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_W_Wool_Runner_Kotare_GREY_ANGLE_0f3bfe63-ac7d-4106-9acf-d26f8414ac53_600x600.png", IsLike = true, Price = 65.21, Title = "Title" });
            storelist.Add(new Store() { Id = 4, ImageUrl = "https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_W_Wool_Runner_Kotare_GREY_ANGLE_0f3bfe63-ac7d-4106-9acf-d26f8414ac53_600x600.png", IsLike = true, Price = 39.95, Title = "Title" });
            storelist.Add(new Store() { Id = 5, ImageUrl = "https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_W_Wool_Runner_Kotare_GREY_ANGLE_0f3bfe63-ac7d-4106-9acf-d26f8414ac53_600x600.png", IsLike = true, Price = 958.99, Title = "Title" });
            storelist.Add(new Store() { Id = 6, ImageUrl = "https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_W_Wool_Runner_Kotare_GREY_ANGLE_0f3bfe63-ac7d-4106-9acf-d26f8414ac53_600x600.png", IsLike = true, Price = 64.85, Title = "Title" });
            storelist.Add(new Store() { Id = 7, ImageUrl = "https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_W_Wool_Runner_Kotare_GREY_ANGLE_0f3bfe63-ac7d-4106-9acf-d26f8414ac53_600x600.png", IsLike = true, Price = 2050.55, Title = "Title" });
            storelist.Add(new Store() { Id = 8, ImageUrl = "https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_W_Wool_Runner_Kotare_GREY_ANGLE_0f3bfe63-ac7d-4106-9acf-d26f8414ac53_600x600.png", IsLike = true, Price = 120500.00, Title = "Title" });
                //CV.ItemsSource = storelist;
            }
            catch (Exception ex)
            {
            }
        }
    }
}

//public class MainPageViewModel
//{
//    public MainPageViewModel()
//    {
//        storelist.Add(new Store() { Id = 1, ImageUrl = "https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_W_Wool_Runner_Kotare_GREY_ANGLE_0f3bfe63-ac7d-4106-9acf-d26f8414ac53_600x600.png", IsLike = true, SubTitle = "Test", Title = "Title" });
//        storelist.Add(new Store() { Id = 2, ImageUrl = "https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_W_Wool_Runner_Kotare_GREY_ANGLE_0f3bfe63-ac7d-4106-9acf-d26f8414ac53_600x600.png", IsLike = true, SubTitle = "Test", Title = "Title" });
//        storelist.Add(new Store() { Id = 3, ImageUrl = "https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_W_Wool_Runner_Kotare_GREY_ANGLE_0f3bfe63-ac7d-4106-9acf-d26f8414ac53_600x600.png", IsLike = true, SubTitle = "Test", Title = "Title" });
//        storelist.Add(new Store() { Id = 4, ImageUrl = "https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_W_Wool_Runner_Kotare_GREY_ANGLE_0f3bfe63-ac7d-4106-9acf-d26f8414ac53_600x600.png", IsLike = true, SubTitle = "Test", Title = "Title" });
//        storelist.Add(new Store() { Id = 5, ImageUrl = "https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_W_Wool_Runner_Kotare_GREY_ANGLE_0f3bfe63-ac7d-4106-9acf-d26f8414ac53_600x600.png", IsLike = true, SubTitle = "Test", Title = "Title" });
//        storelist.Add(new Store() { Id = 6, ImageUrl = "https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_W_Wool_Runner_Kotare_GREY_ANGLE_0f3bfe63-ac7d-4106-9acf-d26f8414ac53_600x600.png", IsLike = true, SubTitle = "Test", Title = "Title" });
//        storelist.Add(new Store() { Id = 7, ImageUrl = "https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_W_Wool_Runner_Kotare_GREY_ANGLE_0f3bfe63-ac7d-4106-9acf-d26f8414ac53_600x600.png", IsLike = true, SubTitle = "Test", Title = "Title" });
//        storelist.Add(new Store() { Id = 8, ImageUrl = "https://cdn.shopify.com/s/files/1/1104/4168/products/Allbirds_W_Wool_Runner_Kotare_GREY_ANGLE_0f3bfe63-ac7d-4106-9acf-d26f8414ac53_600x600.png", IsLike = true, SubTitle = "Test", Title = "Title" });

//    }

    //    private List<Store> storelist;
//    public List<Store> MyProperty
//    {
//        get { return storelist; }
//        set { storelist = value; }
//    }
//}

public class Store
{
    public int Id { get; set; }
    public bool IsLike { get; set; }
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public double Price { get; set; }
    public string Favorite { get; set; } = "favorite.png";
}