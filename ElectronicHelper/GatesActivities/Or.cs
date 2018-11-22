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
    [Activity(Label = "Or")]
    public class Or : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LogicGateLayout);
            this.Title = "OR";

            FindViewById<ImageView>(Resource.Id.ImageGate1).SetImageResource(Resource.Drawable.OR); ;

            FindViewById<ImageView>(Resource.Id.ImageGate2).SetImageResource(Resource.Drawable.ortable);

            FindViewById<TextView>(Resource.Id.textViewGate).Text = "The OR gate is an electronic circuit that gives a high output (1) if one or more of its inputs are high.  A plus (+) is used to show the OR operation.";
            
        }
    }
}