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
    [Activity(Label = "Ohm's Law")]
    public class OhmLaw : Activity
    {
        Button CalculateButton;
        Button Clear;
        TextView Volt;
        TextView Resistance;
        TextView Current;
        Button FindMore;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.ohmslawView);

            CalculateButton = FindViewById<Button>(Resource.Id.CalButtonOhm);
            Clear = FindViewById<Button>(Resource.Id.ClearOhm);
            Volt = FindViewById<TextView>(Resource.Id.txtVolt);
            Resistance = FindViewById<TextView>(Resource.Id.txtResistance);
            Current = FindViewById<TextView>(Resource.Id.txtCurrent);
            FindMore = FindViewById<Button>(Resource.Id.btnReadMoreOhm);

            CalculateButton.Click += CalculateButton_Click;
            Clear.Click += Clear_Click;
            FindMore.Click += FindMore_Click;
        }

        private void FindMore_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("https://en.wikipedia.org/wiki/Ohm%27s_law");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Volt.Text = "";
            Current.Text = "";
            Resistance.Text = "";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (Volt.Text != "" && Current.Text != "" && Resistance.Text != "")
            {
                return;
            }

            if (Volt.Text != "" && Current.Text!="" && Resistance.Text =="")
            {
                Resistance.Text = (Convert.ToDecimal(Volt.Text) / Convert.ToDecimal(Current.Text)).ToString();
            }

            if (Volt.Text == "" && Current.Text != "" && Resistance.Text != "")
            {
                Volt.Text = (Convert.ToDecimal(Resistance.Text) * Convert.ToDecimal(Current.Text)).ToString();
            }

            if (Volt.Text != "" && Current.Text == "" && Resistance.Text != "")
            {
                Current.Text = (Convert.ToDecimal(Volt.Text) * Convert.ToDecimal(Resistance.Text)).ToString();
            }

        }
    }
}