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
    [Activity(Label = "Capacitors")]
    public class Capacitors : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PreviewPage);
            this.Title = "Capasitors Letter Codes";

            var Image = FindViewById<ImageView>(Resource.Id.ImageViewBox);
            Image.SetImageResource(Resource.Drawable.CapacitorCode);
            // Create your application here
        }
    }
}