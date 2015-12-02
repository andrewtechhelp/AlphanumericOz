using AlphanumericOz.Core.Models;
using AlphanumericOz.Core.Services;
using Cirrious.MvvmCross.ViewModels;
using System.Collections.Generic;

namespace AlphanumericOz.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public MainViewModel(IRoutesGenesisService service)
        {
            Routes = service.GenerateSampleRouteData();
        }

        private List<Route> _routes;
        public List<Route> Routes
        {
            get { return _routes; }
            set { _routes = value; RaisePropertyChanged(() => Routes); }
        }

        public IMvxCommand ViewRouteCommand
        {
            get
            {
                return new MvxCommand<Route>(parameter =>
                {
                    ShowViewModel<RouteViewModel>(new { routeNumber = parameter.RouteNumber });
                });
            }
        }
    }
}
