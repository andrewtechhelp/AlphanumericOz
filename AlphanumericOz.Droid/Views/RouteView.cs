using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace AlphanumericOz.Droid.Views
{
    [Activity(Label = "Route Details")]
    public class RouteView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.RouteView);
        }
    }
}