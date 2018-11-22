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
    [Activity(Label = "Eor")]
    public class Eor : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LogicGateLayout);
            this.Title = "EX-OR";

            FindViewById<ImageView>(Resource.Id.ImageGate1).SetImageResource(Resource.Drawable.EOR); ;

            FindViewById<ImageView>(Resource.Id.ImageGate2).SetImageResource(Resource.Drawable.eortable);

            FindViewById<TextView>(Resource.Id.textViewGate).Text = "The 'Exclusive-OR' gate is a circuit which will give a high output if either, but not both, of its two inputs are high.  An encircled plus sign () is used to show the EOR operation.";

        }
    }
}