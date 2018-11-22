using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using ElectronicHelper.GatesActivities;

namespace ElectronicHelper.Views
{
    public class MainFragment : Fragment
    {

        ListView listView;
        List<TableItem> tableItems = new List<TableItem>();

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.HomeScreen, null);

            listView = view.FindViewById<ListView>(Resource.Id.List);
            tableItems.Clear();
            tableItems.Add(new TableItem() { Heading = "Resisters Colour code", SubHeading = "", ImageResourceId = Resource.Drawable.Resisters, Id = 1 });
            tableItems.Add(new TableItem() { Heading = "Ceramic Capacitor Chart", SubHeading = "", ImageResourceId = Resource.Drawable.Capacitors, Id = 2 });
            tableItems.Add(new TableItem() { Heading = "LED Colour Chart", SubHeading = "", ImageResourceId = Resource.Drawable.LED, Id = 3 });
            tableItems.Add(new TableItem() { Heading = "Trnsister types", SubHeading = "", ImageResourceId = Resource.Drawable.Transisters, Id = 4 });
            tableItems.Add(new TableItem() { Heading = "Switch types", SubHeading = "", ImageResourceId = Resource.Drawable.SwitchIcon, Id = 5 });



            listView.Adapter = new HomeScreenAdapter(this.Activity, tableItems);

            listView.ItemClick += OnListItemClick;

            return view;
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
                    intent = new Intent(this.Activity, typeof(Resisters));
                    break;

                case 2:
                    intent = new Intent(this.Activity, typeof(Capacitors));
                    break;

                case 3:
                    intent = new Intent(this.Activity, typeof(LED));
                    break;

                case 4:
                    intent = new Intent(this.Activity, typeof(Transisters));
                    break;

                case 5:
                    intent = new Intent(this.Activity, typeof(SwitchTypes));
                    break;



            }

            intent.AddFlags(ActivityFlags.NewTask);
            StartActivity(intent);

        }

    }

    public class CalculationsFragment : Fragment
    {
        List<TableItem> tableItems = new List<TableItem>();
        ListView listView;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.CalculationView, null);

            listView = view.FindViewById<ListView>(Resource.Id.ListCalculationView);
            tableItems.Clear();
            tableItems.Add(new TableItem() { Heading = "Ohm's Law", SubHeading = "V = IR", ImageResourceId = Resource.Drawable.ohmslaw, Id = 1 });
            tableItems.Add(new TableItem() { Heading = "Power", SubHeading = "P = VI", ImageResourceId = Resource.Drawable.power, Id = 2 });

            listView.Adapter = new CalculationAdapter(this.Activity, tableItems);

            listView.ItemClick += OnListItemClick;


            return view;
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
                    intent = new Intent(this.Activity, typeof(OhmLaw));
                    break;

                case 2:
                    intent = new Intent(this.Activity, typeof(Power));
                    break;

            }


            intent.AddFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }
    }

    public class ConnectorsFragment : Fragment
    {
        List<TableItem> tableItems = new List<TableItem>();
        ListView listView;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.CalculationView, null);

            listView = view.FindViewById<ListView>(Resource.Id.ListCalculationView);
            tableItems.Clear();
            tableItems.Add(new TableItem() { Heading = "Coaxial Cable Connectors", SubHeading = "", ImageResourceId = Resource.Drawable.IconCoxial, Id = 1 });
            tableItems.Add(new TableItem() { Heading = "USB Connectors", SubHeading = "", ImageResourceId = Resource.Drawable.usbicon, Id = 2 });
            tableItems.Add(new TableItem() { Heading = "Wall plug types", SubHeading = "", ImageResourceId = Resource.Drawable.iconplugs, Id = 3 });
            tableItems.Add(new TableItem() { Heading = "Wall plug types by country", SubHeading = "", ImageResourceId = Resource.Drawable.plug, Id = 4 });


            listView.Adapter = new CalculationAdapter(this.Activity, tableItems);

            listView.ItemClick += OnListItemClick;

            return view;
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
                    intent = new Intent(this.Activity, typeof(RFCables));
                    break;

                case 2:
                    intent = new Intent(this.Activity, typeof(UsbTypes));
                    break;
                case 3:
                    intent = new Intent(this.Activity, typeof(PlugTypes));
                    break;
                case 4:
                    intent = new Intent(this.Activity, typeof(WallPlugTypeByCountry));
                    break;

            }


            intent.AddFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }
    }



    public class OtherFragment : Fragment
    {
        List<TableItem> tableItems = new List<TableItem>();
        ListView listView;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.CalculationView, null);

            listView = view.FindViewById<ListView>(Resource.Id.ListCalculationView);
            tableItems.Clear();
            tableItems.Add(new TableItem() { Heading = "Voltage by Country", SubHeading = "", ImageResourceId = Resource.Drawable.globe, Id = 1 });

            listView.Adapter = new CalculationAdapter(this.Activity, tableItems);

            listView.ItemClick += OnListItemClick;
            return view;
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
                    intent = new Intent(this.Activity, typeof(VoltageByCountry));
                    break;


            }


            intent.AddFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }
    }

    public class logicGateFragment : Fragment
    {
        List<TableItem> tableItems = new List<TableItem>();
        ListView listView;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.CalculationView, null);

            listView = view.FindViewById<ListView>(Resource.Id.ListCalculationView);
            tableItems.Clear();
            tableItems.Add(new TableItem() { Heading = "AND", SubHeading = "", ImageResourceId = Resource.Drawable.And, Id = 1 });
            tableItems.Add(new TableItem() { Heading = "OR", SubHeading = "", ImageResourceId = Resource.Drawable.OR, Id = 2 });
            tableItems.Add(new TableItem() { Heading = "NOT", SubHeading = "", ImageResourceId = Resource.Drawable.NOT, Id = 3 });
            tableItems.Add(new TableItem() { Heading = "NAND", SubHeading = "", ImageResourceId = Resource.Drawable.NAND, Id = 4 });
            tableItems.Add(new TableItem() { Heading = "NOR", SubHeading = "", ImageResourceId = Resource.Drawable.NOR, Id = 5 });

            tableItems.Add(new TableItem() { Heading = "EX-OR", SubHeading = "", ImageResourceId = Resource.Drawable.EOR, Id = 6 });
            tableItems.Add(new TableItem() { Heading = "EX-NOR", SubHeading = "", ImageResourceId = Resource.Drawable.ENOR, Id = 7 });

            listView.Adapter = new CalculationAdapter(this.Activity, tableItems);

            listView.ItemClick += OnListItemClick;
            return view;
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
                    intent = new Intent(this.Activity, typeof(And));
                    break;

                case 2:
                    intent = new Intent(this.Activity, typeof(Or));
                    break;
                case 3:
                    intent = new Intent(this.Activity, typeof(Not));
                    break;
                case 4:
                    intent = new Intent(this.Activity, typeof(Nand));
                    break;
                case 5:
                    intent = new Intent(this.Activity, typeof(Nor));
                    break;
                case 6:
                    intent = new Intent(this.Activity, typeof(Eor));
                    break;
                case 7:
                    intent = new Intent(this.Activity, typeof(Enor));
                    break;


            }


            intent.AddFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }
    }

    public class ArduinoFragment : Fragment
    {
        List<TableItem> tableItems = new List<TableItem>();
        ListView listView;

        

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.ArduinoView, null);

            listView = view.FindViewById<ListView>(Resource.Id.ListArduinoView);
            tableItems.Clear();
            tableItems.Add(new TableItem() { Heading = "UNO", SubHeading = "", ImageResourceId = Resource.Drawable.unoIcon, Id = 1 });
            tableItems.Add(new TableItem() { Heading = "LEONARDO", SubHeading = "", ImageResourceId = Resource.Drawable.leonardoIcon, Id = 2 });
            tableItems.Add(new TableItem() { Heading = "NANO", SubHeading = "", ImageResourceId = Resource.Drawable.nanoIcon, Id = 3 });
            tableItems.Add(new TableItem() { Heading = "MICRO", SubHeading = "", ImageResourceId = Resource.Drawable.microIcon, Id = 4 });
            tableItems.Add(new TableItem() { Heading = "MINI", SubHeading = "", ImageResourceId = Resource.Drawable.miniIcon, Id = 5 });
            tableItems.Add(new TableItem() { Heading = "101", SubHeading = "", ImageResourceId = Resource.Drawable.oneZeroOneIcon, Id = 6 });
            tableItems.Add(new TableItem() { Heading = "ESPLORA", SubHeading = "", ImageResourceId = Resource.Drawable.esploraIcon, Id = 7 });
            tableItems.Add(new TableItem() { Heading = "MEGA", SubHeading = "", ImageResourceId = Resource.Drawable.megaIcon, Id = 8 });
            tableItems.Add(new TableItem() { Heading = "DUE", SubHeading = "", ImageResourceId = Resource.Drawable.dueIcon, Id = 9 });
            tableItems.Add(new TableItem() { Heading = "INDUSTRIAL", SubHeading = "", ImageResourceId = Resource.Drawable.industrialIcon, Id = 10 });
            tableItems.Add(new TableItem() { Heading = "YUN", SubHeading = "", ImageResourceId = Resource.Drawable.yunIcon, Id = 11 });
            tableItems.Add(new TableItem() { Heading = "TIAN", SubHeading = "", ImageResourceId = Resource.Drawable.tianIcon, Id = 12 });
            tableItems.Add(new TableItem() { Heading = "LILYPAD", SubHeading = "", ImageResourceId = Resource.Drawable.lilypadIcon, Id = 13 });

            listView.Adapter = new CalculationAdapter(this.Activity, tableItems);

            listView.ItemClick += OnListItemClick;
            return view;
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

                    Common.arduinoImage = Resource.Drawable.uno;
                    
                    break;
                case 2:

                    Common.arduinoImage = Resource.Drawable.Leonardo;
                    break;
                case 3:

                    Common.arduinoImage = Resource.Drawable.nano;
                    break;
                case 4:

                    Common.arduinoImage = Resource.Drawable.micro;
                    break;
                case 5:

                    Common.arduinoImage = Resource.Drawable.mini;
                    break;
                case 6:

                    Common.arduinoImage = Resource.Drawable.onezeroone;
                    break;
                case 7:

                    Common.arduinoImage = Resource.Drawable.esplora;
                    break;
                case 8:

                    Common.arduinoImage = Resource.Drawable.mega;
                    break;
                case 9:

                    Common.arduinoImage = Resource.Drawable.due;
                    break;
                case 10:

                    Common.arduinoImage = Resource.Drawable.Industrial;
                    break;
                case 11:

                    Common.arduinoImage = Resource.Drawable.yun;
                    break;

                case 12:

                    Common.arduinoImage = Resource.Drawable.Tian;
                    break;

                case 13:

                    Common.arduinoImage = Resource.Drawable.LilyPad;
                    break;



            }

            Common.title = t.Heading;
            intent = new Intent(this.Activity, typeof(ArduinoPage));
            intent.AddFlags(ActivityFlags.NewTask);
            StartActivity(intent);
        }
    }

    public class EbooksFragment : Fragment
    {
        List<TableItem> tableItems = new List<TableItem>();
        ListView listView;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.CalculationView, null);

            listView = view.FindViewById<ListView>(Resource.Id.ListCalculationView);
            tableItems.Clear();
            tableItems.Add(new TableItem() { Heading = "Basic Electronics", SubHeading = "", Id = 1 });
            tableItems.Add(new TableItem() { Heading = "Basic Electronic Tutorials", SubHeading = "Wayne Storr", Id = 2 });
            tableItems.Add(new TableItem() { Heading = "Basic Electronics", SubHeading = "Jack Ganssle", ImageResourceId = 0, Id = 3 });
            tableItems.Add(new TableItem() { Heading = "Electronics and Communication Eng", SubHeading = "K. A. NAVAS |T. A. Suhail", Id = 4 });
            tableItems.Add(new TableItem() { Heading = "Electronics", SubHeading = "en.wikibooks.org", Id = 5 });
            tableItems.Add(new TableItem() { Heading = "Principles of Electronics", SubHeading = "V.K. Mehta",  Id = 6 });
            tableItems.Add(new TableItem() { Heading = "Electronic Devices", SubHeading = "THOMAS L. FLOYD",  Id = 7 });
            tableItems.Add(new TableItem() { Heading = "Schaum Outlines Electric Circuits", SubHeading = "", Id = 8 });
            tableItems.Add(new TableItem() { Heading = "Electronics Demystified", SubHeading = "Stan Gibilisco", Id = 9 });
            tableItems.Add(new TableItem() { Heading = "Digital Electronics Demystified", SubHeading = "Myke Predko",Id = 10});
            tableItems.Add(new TableItem() { Heading = "Digital Fundamentals", SubHeading = "Thomas L. Floyd", Id = 11 });
            tableItems.Add(new TableItem() { Heading = "Complete Electronics", SubHeading = "Earl Boysen | Harry Kybett",  Id = 12 });
            tableItems.Add(new TableItem() { Heading = "Basics of Electricity/Electronics", SubHeading = "Fabian Winkler",  Id = 13 });
            tableItems.Add(new TableItem() { Heading = "Teach Yourself Electronics", SubHeading = "Stan Gibilisco", Id = 14 });
            tableItems.Add(new TableItem() { Heading = "Digital Electronics", SubHeading = "Dr. I. J. Wassell",  Id = 15 });
            tableItems.Add(new TableItem() { Heading = "Introduction to Electronics", SubHeading = "Bob Zulinski",  Id = 16 });
            tableItems.Add(new TableItem() { Heading = "Basics of RF electronics", SubHeading = "A. Gallo",  Id = 17 });
            tableItems.Add(new TableItem() { Heading = "Introduction to Physical Electronics", SubHeading = "Bill Wilson",  Id = 18 });
            tableItems.Add(new TableItem() { Heading = "Digital Electronics", SubHeading = "Anil K. Maini", Id = 19 });
            tableItems.Add(new TableItem() { Heading = "Make: Electronics", SubHeading = "Charles Platt", Id = 20 });
            tableItems.Add(new TableItem() { Heading = "Creative Inquiry Electronics Project", SubHeading = "", Id = 21 });
            tableItems.Add(new TableItem() { Heading = "Digital Electronics", SubHeading = "", Id = 22 });

            tableItems.Add(new TableItem() { Heading = "Basic Electronics", SubHeading = "Curtis A. Meyer", Id = 23 });
            listView.Adapter = new EbooksAdapter(this.Activity, tableItems);

            listView.ItemClick += OnListItemClick;
            return view;
        }

        private void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var listView = sender as ListView;
            var t = tableItems[e.Position];
            string book = "";
            var id = t.Id;
            Intent intent = new Intent();

            switch (id)
            {
                case 1:
                    book = "http://engineering.nyu.edu/gk12/amps-cbri/pdf/Basic%20Electronics.pdf";
                    break;

                case 2:
                    book = "https://www.electronics-tutorials.ws/pdf/basic-electronics-tutorials.pdf";
                    break;
                case 3:
                    book = "https://booksite.elsevier.com/samplechapters/9780750676069/9780750676069.PDF";
                    break;
                case 4:
                    book = "http://www.edutalks.org/releases/Em1.pdf";
                    break;
                case 5:
                    book = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Electronics.pdf";
                    break;
                case 6:
                    book = "https://drive.google.com/file/d/1Wj2IxBFxy1fuCycC5YpMhoVBVuPxHPWq/view";
                    break;
                case 7:
                    book = "https://drive.google.com/file/d/1wetTaYq30rQPUVhzx3f8PSKyD72EH2bE/view";
                    break;
                case 8:
                    book = "https://drive.google.com/file/d/1O_ZwlA33X_p71raP87poiqmYewZBR2n9/view";
                    break;
                case 9:
                    book = "https://drive.google.com/file/d/1PYed97OJ_Ee8Cn9GNAloXEyKl_QHvth-/view";
                    break;
                case 10:
                    book = "https://drive.google.com/file/d/1-8j-RmA_HVVA6pRAYNVZJMKOY2S_b71G/view";
                    break;
                case 11:
                    book = "https://drive.google.com/file/d/1IlEAF0IBZRNwHLfKiHHoUYCoVVbIoan3/view";
                    break;
                case 12:
                    book = "https://gurusaiprasanth.files.wordpress.com/2015/10/complete-electronics-self-teaching-guide-with-projects-honest.pdf";
                    break;
                case 13:
                    book = "https://www.cla.purdue.edu/academic/rueffschool/ad/etb/resources/electronics_01.pdf";
                    break;
                case 14:
                    book = "http://webwork.utleon.edu.mx/Paginas/Documentos/Robotica/electronica/(ebook)%20Gibilisco,%20Stan%20-%20Teach%20Yourself%20Electricity%20and%20Electronics.pdf";
                    break;
                case 15:
                    book = "https://www.cl.cam.ac.uk/teaching/0708/DigElec/Digital_Electronics_pdf.pdf";
                    break;
                case 16:
                    book = "http://www.ece.mtu.edu/faculty/ljbohman/onlinetext/elint200.pdf";
                    break;
                case 17:
                    book = "https://cds.cern.ch/record/1407402/files/p223.pdf";
                    break;
                case 18:
                    book = "http://elibrary.bsu.az/books_250/N_220.pdf";
                    break;
                case 19:
                    book = "http://mirror.thelifeofkenneth.com/lib/electronics_archive/DigitalElectronicsBook.pdf";
                    break;
                case 20:
                    book = "https://makezine.com/wp-content/uploads/2014/01/make-electronics-excerpt.pdf";
                    break;
                case 21:
                    book = "https://www.clemson.edu/cecas/departments/ece/document_resource/undergrad/electronics/CInquiryLabManual.pdf";
                    break;
                case 22:
                    book = "https://faraday.physics.utoronto.ca/IYearLab/digital.pdf";
                    break;
                case 23:
                    book = "http://www.phys.uni-sofia.bg/~dankov/P%20Dankov_Lecture%20materials/Bachelor%20course%20ORE/references/BasicElectronics.pdf";
                    break;
            }

            var uri = Android.Net.Uri.Parse(book);
            Intent inte = new Intent(Intent.ActionView, uri);
            StartActivity(inte);
        }
    }
}