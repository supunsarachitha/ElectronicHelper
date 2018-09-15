using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ElectronicHelper
{
    [Activity(Label = "Resisters")]
    public class Resisters : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PreviewPage);
            this.Title = "Capasitors Colour Code";

            var Image = FindViewById<ImageView>(Resource.Id.ImageViewBox);
            Image.SetImageResource(Resource.Drawable.ColourCodeResisters);
            // Create your application here
        }
    }
}