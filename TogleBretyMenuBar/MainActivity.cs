using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using SupportToolbar = Android.Support.V7.Widget.Toolbar;
namespace TogleBretyMenuBar
{
    [Activity(Label = "TogleBretyMenuBar", MainLauncher = true,Theme ="@style/MyTheme")]
    public class MainActivity : AppCompatActivity
    {
        private SupportToolbar mTolbar;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mTolbar = FindViewById<SupportToolbar>(Resource.Id.toolbar);
            SetSupportActionBar(mTolbar);
        }
    }
}

