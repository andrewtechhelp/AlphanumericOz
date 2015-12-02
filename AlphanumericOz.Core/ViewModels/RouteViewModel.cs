using AlphanumericOz.Core.Models;
using AlphanumericOz.Core.Services;
using Cirrious.MvvmCross.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace AlphanumericOz.Core.ViewModels
{
    public class RouteViewModel : MvxViewModel
    {
        public RouteViewModel(IRoutesGenesisService service)
        {
            Routes = service.GenerateSampleRouteData();
        }

        private List<Route> _routes;
        public List<Route> Routes
        {
            get { return _routes; }
            set { _routes = value; RaisePropertyChanged(() => Routes); }
        }

        private List<Road> _roads;
        public List<Road> Roads
        {
            get { return _roads; }
            set { _roads = value; RaisePropertyChanged(() => Roads); }
        }

        public void Init(string routeNumber)
        {
            var selectedRoute = from route in _routes
                                where route.RouteNumber == routeNumber
                                select route;

            Roads = selectedRoute.FirstOrDefault().Roads;
        }
    }
}
