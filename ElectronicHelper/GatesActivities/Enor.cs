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
    [Activity(Label = "Enor")]
    public class Enor : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LogicGateLayout);
            this.Title = "EXNOR";

            FindViewById<ImageView>(Resource.Id.ImageGate1).SetImageResource(Resource.Drawable.ENOR); ;

            FindViewById<ImageView>(Resource.Id.ImageGate2).SetImageResource(Resource.Drawable.enortable);

            FindViewById<TextView>(Resource.Id.textViewGate).Text = "The 'Exclusive-NOR' gate circuit does the opposite to the EOR gate. It will give a low output if either, but not both, of its two inputs are high. The symbol is an EXOR gate with a small circle on the output. The small circle represents inversion.";

        }
    }
}