using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace ElectronicHelper
{
    [Activity(Label = "Electronic Helper", MainLauncher = true, Icon = "@drawable/Icon", Theme = "@style/MyTheme")]
    public class HomeScreen : Activity
    {

        List<TableItem> tableItems = new List<TableItem>();
        ListView listView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            //SetActionBar(toolbar);

            SetContentView(Resource.Layout.HomeScreen);
            listView = FindViewById<ListView>(Resource.Id.List);

            tableItems.Add(new TableItem() { Heading = "Resisters", SubHeading = "", ImageResourceId = Resource.Drawable.Resisters, Id=1 });
            tableItems.Add(new TableItem() { Heading = "Ceramic Capacitors", SubHeading = "", ImageResourceId = Resource.Drawable.Capacitors, Id =2 });
            tableItems.Add(new TableItem() { Heading = "LEDs", SubHeading = "", ImageResourceId = Resource.Drawable.LED, Id = 3 });
            tableItems.Add(new TableItem() { Heading = "Trnsisters", SubHeading = "", ImageResourceId = Resource.Drawable.Transisters, Id = 4 });
            tableItems.Add(new TableItem() { Heading = "Calculations", SubHeading = "", ImageResourceId = Resource.Drawable.calculation, Id = 5 });
            
            listView.Adapter = new HomeScreenAdapter(this, tableItems);

            listView.ItemClick += OnListItemClick;


            

        }

        protected void OnListItemClick(object sender, Android.Widget.AdapterView.ItemClickEventArgs e)
        {
            var listView = sender as ListView;
            var t = tableItems[e.Position];

            var id = t.Id;
            Intent intent = new Intent();

            switch (id)
            {
                case 1:
                    intent = new Intent(this, typeof(Resisters));
                    break;

                case 2:
                    intent = new Intent(this, typeof(Capacitors));
                    break;

                case 3:
                    intent = new Intent(this, typeof(LED));
                    break;

                case 4:
                    intent = new Intent(this, typeof(Transisters));
                    break;

                case 5:
                    intent = new Intent(this, typeof(Calculations));
                    break;
            }

            intent.AddFlags(ActivityFlags.NewTask);
            StartActivity(intent);

        }
    }
}