using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace FragmentEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);



            FirstFragment objFist = new FirstFragment();

            FragmentManager fm = FragmentManager;
            FragmentTransaction ft = fm.BeginTransaction();

            ft.Add(Resource.Id.flContainer, objFist);


            SecondFragment second = new SecondFragment();
            ft.Add(Resource.Id.flContainer1, second);

            ft.CommitAllowingStateLoss();

        }
    }
}