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
using ElectronicHelper.Views;

namespace ElectronicHelper
{
    [Activity(Label = "Calculations")]
    public class Calculations : Activity
    {
        List<TableItem> tableItems = new List<TableItem>();
        ListView listView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CalculationView);
            listView = FindViewById<ListView>(Resource.Id.ListCalculationView);

            tableItems.Add(new TableItem() { Heading = "Ohm's Law", SubHeading = "V = IR", ImageResourceId = Resource.Drawable.ohmslaw, Id = 1 });
            tableItems.Add(new TableItem() { Heading = "Power", SubHeading = "P = VI", ImageResourceId = Resource.Drawable.power, Id = 2 });



            listView.Adapter = new CalculationAdapter(this, tableItems);

            listView.ItemClick += OnListItemClick;
        }

        private void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var listView = sender as ListView;
            var t = tableItems[e.Position];

            var id = t.Id;
            Intent intent = new Intent();

            switch (id)
            {
                case 1:
                    intent = new Intent(this, typeof(OhmLaw));
                    break;

                case 2:
                    intent = new Intent(this, typeof(Power));
                    break;

            }


            intent.AddFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }
    }
}