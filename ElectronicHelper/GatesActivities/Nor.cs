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

namespace ElectronicHelper.GatesActivities
{
    [Activity(Label = "Nor")]
    public class Nor : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LogicGateLayout);
            this.Title = "NOR";

            FindViewById<ImageView>(Resource.Id.ImageGate1).SetImageResource(Resource.Drawable.NOR); ;

            FindViewById<ImageView>(Resource.Id.ImageGate2).SetImageResource(Resource.Drawable.nortable);

            FindViewById<TextView>(Resource.Id.textViewGate).Text = "This is a NOT-OR gate which is equal to an OR gate followed by a NOT gate.  The outputs of all NOR gates are low if any of the inputs are high.The symbol is an OR gate with a small circle on the output. The small circle represents inversion.";

        }
    }
}