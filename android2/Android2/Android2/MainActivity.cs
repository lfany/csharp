using Android.App;
using Android.OS;
using Android.Util;
using System;

namespace Android2
{
    [Activity(Label = "Android2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private String TAG = typeof(MainActivity).ToString();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
            SetContentView(Resource.Layout.Main);

            // test log & print
            Console.WriteLine("Hello world");
            Console.Write("~~~~\n");
            Log.Verbose(TAG, "log test"); 
        }
    }
}

