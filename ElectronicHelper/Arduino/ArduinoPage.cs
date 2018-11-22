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

namespace ElectronicHelper.Views
{
    [Activity(Label = "Arduino")]
    public class ArduinoPage : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.ImageView);
            this.Title = Common.title;

            var Image = FindViewById<ElectronicHelper.Views.ScaleImageView>(Resource.Id.ScaleImg);

            Image.SetImageResource(Common.arduinoImage);
            // Create your application here
        }
    }
}