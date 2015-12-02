using AlphanumericOz.Core.ViewModels;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Touch.Views;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace AlphanumericOz.iOS.Views
{
    [Register("MainView")]
    public class MainView : MvxTableViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.Title = "AlphanumericOz";

            // ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
            {
                EdgesForExtendedLayout = UIRectEdge.None;
            }

            var source = new MvxStandardTableViewSource(TableView, UITableViewCellStyle.Subtitle, new NSString("cell"), "TitleText RouteNumber;DetailText RouteClassification;ImageUrl Image");
            TableView.Source = source;

            var set = this.CreateBindingSet<MainView, MainViewModel>();
            set.Bind(source).To(vm => vm.Routes);
            set.Bind(source).For(s => s.SelectionChangedCommand).To(vm => vm.ViewRouteCommand);
            set.Apply();

            TableView.ReloadData();
        }
    }
}