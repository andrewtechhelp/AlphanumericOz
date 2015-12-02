using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace AlphanumericOz.Droid.Views
{
    [Activity(Label = "AlphanumericOz")]
    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
        }
    }
}