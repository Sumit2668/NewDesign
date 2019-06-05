using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NewDesignTestApp.AnimationTrigger
{
    public class ExpandButtonTriggerAction : TriggerAction<ImageButton>
    {
        protected async override void Invoke(ImageButton button)
        {
            Xamarin.Forms.ImageButton img = (Xamarin.Forms.ImageButton)button;
            Xamarin.Forms.FileImageSource objFileImageSource = (Xamarin.Forms.FileImageSource)img.Source;
            if (objFileImageSource.File == "yes.png")
            {
                button.Source = "no.png";
            }
            else
            {
                button.Source = "yes.png";
            }

        }
    }
}
