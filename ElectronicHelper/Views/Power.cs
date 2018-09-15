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
    [Activity(Label = "Power")]
    public class Power : Activity
    {
        Button CalculateButton;
        Button Clear;
        TextView watt;
        TextView Current;
        TextView Volt;
        Button FindMore;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PowerView);


            CalculateButton = FindViewById<Button>(Resource.Id.CalButtonOhm);
            Clear = FindViewById<Button>(Resource.Id.ClearOhm);
            watt = FindViewById<TextView>(Resource.Id.txtWatt);
            Current = FindViewById<TextView>(Resource.Id.txtCurrent);
            Volt = FindViewById<TextView>(Resource.Id.txtVolt);
            FindMore = FindViewById<Button>(Resource.Id.btnReadMoreOhm);

            CalculateButton.Click += CalculateButton_Click;
            Clear.Click += Clear_Click;
            FindMore.Click += FindMore_Click;
        }

        private void FindMore_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("https://en.wikipedia.org/wiki/Electric_power");
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            watt.Text = "";
            Volt.Text = "";
            Current.Text = "";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (watt.Text != "" && Volt.Text != "" && Current.Text != "")
            {
                return;
            }

            if (watt.Text != "" && Volt.Text != "" && Current.Text == "")
            {
                Current.Text = (Convert.ToDecimal(watt.Text) / Convert.ToDecimal(Volt.Text)).ToString();
            }

            if (watt.Text == "" && Volt.Text != "" && Current.Text != "")
            {
                watt.Text = (Convert.ToDecimal(Current.Text) * Convert.ToDecimal(Volt.Text)).ToString();
            }

            if (watt.Text != "" && Volt.Text == "" && Current.Text != "")
            {
                Volt.Text = (Convert.ToDecimal(watt.Text) * Convert.ToDecimal(Current.Text)).ToString();
            }

        }
    }
}