using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using ElectronicHelper.Views;

namespace ElectronicHelper
{
    [Activity(Label = "Electronic Helper", MainLauncher = false, Icon = "@drawable/Icon", Theme = "@style/MyTheme")]
    public class HomeScreen : Activity
    {

        Fragment[] _fragments;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

            SetContentView(Resource.Layout.Main);



            try
            {
                var editToolbar = FindViewById<Toolbar>(Resource.Id.edit_toolbar);
                editToolbar.InflateMenu(Resource.Menu.top_menus);
                editToolbar.MenuItemClick += (sender, e) => {
                    if (e.Item.TitleFormatted.ToString() == "Share")
                    {
                        Intent sendIntent = new Intent();
                        sendIntent.SetAction(Intent.ActionSend);
                        sendIntent.PutExtra(Intent.ExtraText, "https://play.google.com/store/apps/details?id=lk.stechbuzz.electronic");
                        sendIntent.SetType("text/plain");
                        StartActivity(sendIntent);



                    }

                    if (e.Item.TitleFormatted.ToString() == "Rate")
                    {
                        Android.App.AlertDialog.Builder dialog = new AlertDialog.Builder(this);
                        AlertDialog alert = dialog.Create();
                        alert.SetTitle("Rate this app");
                        alert.SetMessage("Rate this app or write a feedback");
                        alert.SetIcon(Resource.Drawable.alert);
                        alert.SetButton("OK", (c, ev) =>
                        {
                            this.RunOnUiThread(() => Toast.MakeText(this, "Thank you!", ToastLength.Short).Show());
                            Android.Net.Uri uri = Android.Net.Uri.Parse("market://details?id=" + "lk.stechbuzz.electronic");
                            var openmarket = new Intent(Intent.ActionView, uri);
                            openmarket.AddFlags(ActivityFlags.ExcludeFromRecents);
                            openmarket.SetFlags(ActivityFlags.NoHistory);
                            StartActivity(openmarket);
                        });
                        alert.SetButton2("CANCEL", (c, ev) => { });
                        alert.Show();
                    }

                    if (e.Item.TitleFormatted.ToString() == "Contact us")
                    {
                        var emailIntent = new Intent(Android.Content.Intent.ActionSend);
                        emailIntent.PutExtra(Android.Content.Intent.ExtraEmail, new[] { "stechbuzz@gmail.com" });
                        emailIntent.SetType("text/plain");
                        StartActivity(Intent.CreateChooser(emailIntent, "Contact with us by e-mail"));
                    }

                    if (e.Item.TitleFormatted.ToString() == "Info")
                    {
                        Android.App.AlertDialog.Builder dialog = new AlertDialog.Builder(this);
                        AlertDialog alert = dialog.Create();
                        alert.SetTitle("About app");
                        alert.SetMessage("Electronic Helper is a very small tool that designed to help day today activities for electronic engineers and student. This brings all electronic components to one place and provide basic ideas about electronic components.");
                        alert.SetIcon(Resource.Drawable.alert);
                        alert.SetButton("OK", (c, ev) =>
                        {
                            
                        });
                        alert.Show();
                    }
                };
            }
            catch (Exception)
            {

                return;
            }
            


            _fragments = new Fragment[]
                         {
                             new MainFragment(),
                             new CalculationsFragment(),
                             new ConnectorsFragment(),
                             new logicGateFragment(),
                             new ArduinoFragment(),
                             new EbooksFragment(),
                         };

            AddTabToActionBar(Resource.String.whatson_tab_label);
            AddTabToActionBar(Resource.String.speakers_tab_label);
            AddTabToActionBar(Resource.String.sessions_tab_label);
            AddTabToActionBar(Resource.String.Logic_Geate_Label);
            AddTabToActionBar(Resource.String.Arduino_label);
            AddTabToActionBar(Resource.String.ebooks_label);


        }

        void AddTabToActionBar(int labelResourceId)
        {
            ActionBar.Tab tab = ActionBar.NewTab().SetText(labelResourceId);

            tab.TabSelected += TabOnTabSelected;
            ActionBar.AddTab(tab);
        }

        void TabOnTabSelected(object sender, ActionBar.TabEventArgs tabEventArgs)
        {
            ActionBar.Tab tab = (ActionBar.Tab)sender;

            Fragment frag = _fragments[tab.Position];
            tabEventArgs.FragmentTransaction.Replace(Resource.Id.frameLayout1, frag);
        }


        public override void OnBackPressed()
        {

                Android.App.AlertDialog.Builder dialog = new AlertDialog.Builder(this);
                AlertDialog alert = dialog.Create();
                alert.SetTitle("Exit");
                alert.SetMessage("Do You want to exit?");
                alert.SetIcon(Resource.Drawable.alert);
                alert.SetButton("OK", (c, ev) =>
                {
                    this.Finish();
                    base.OnBackPressed();
                });
                alert.SetButton2("CANCEL", (c, ev) => { });
                alert.Show();



            // Disable pressing back, yo!
        }
    }
}