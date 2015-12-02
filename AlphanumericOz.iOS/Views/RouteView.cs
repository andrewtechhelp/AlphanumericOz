using System;
using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Touch.Views;
using AlphanumericOz.Core.ViewModels;
using CoreFoundation;
using ObjCRuntime;
using UIKit;
using Foundation;

namespace AlphanumericOz.iOS.Views
{
    [Register("RouteView")]
    public class RouteView : MvxTableViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.Title = "Route Details";

            // ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
            {
                EdgesForExtendedLayout = UIRectEdge.None;
            }

            var source = new MvxStandardTableViewSource(TableView, UITableViewCellStyle.Subtitle, new NSString("cell"), "TitleText Name");
            TableView.Source = source;

            var set = this.CreateBindingSet<RouteView, RouteViewModel>();
            set.Bind(source).To(vm => vm.Roads);
            set.Apply();

            TableView.ReloadData();
        }
    }
}