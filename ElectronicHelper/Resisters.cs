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

            SetContentView(Resource.Layout.ImageView);
            this.Title = "Resister Colour Code";

            var Image = FindViewById<ElectronicHelper.Views.ScaleImageView>(Resource.Id.ScaleImg);

            Image.SetImageResource(Resource.Drawable.ColourCodeResisters);
            // Create your application here
        }
    }
}