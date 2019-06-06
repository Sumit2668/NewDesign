using NewDesignTestApp.CustomControls;
using NewDesignTestApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace NewDesignTestApp.Droid.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
       public CustomEntryRenderer() : base() { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = null;

                var layoutParams = new MarginLayoutParams(Control.LayoutParameters);
                layoutParams.SetMargins(0, 0, 0, 0);
                LayoutParameters = layoutParams;
                Control.LayoutParameters = layoutParams;
                Control.SetPadding(12, 12, 0, 0);
                SetPadding(0, 0, 0, 0);
            }
        }
    }
}