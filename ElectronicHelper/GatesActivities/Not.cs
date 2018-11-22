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
    [Activity(Label = "Not")]
    public class Not : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LogicGateLayout);
            this.Title = "NOT";

            FindViewById<ImageView>(Resource.Id.ImageGate1).SetImageResource(Resource.Drawable.NOT); ;

            FindViewById<ImageView>(Resource.Id.ImageGate2).SetImageResource(Resource.Drawable.nottable);

            FindViewById<TextView>(Resource.Id.textViewGate).Text = "The NOT gate is an electronic circuit that produces an inverted version of the input at its output.  It is also known as an inverter.  If the input variable is A, the inverted output is known as NOT A.  This is also shown as A', or A with a bar over the top, as shown at the outputs. The diagrams below show two ways that the NAND logic gate can be configured to produce a NOT gate. It can also be done using NOR logic gates in the same way.";

        }
    }
}