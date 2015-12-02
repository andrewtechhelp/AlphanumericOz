using AlphanumericOz.Core.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AlphanumericOz.Core.Models
{
    public class Route
    {
        public string Id { get; set; }

        private string _routeNumber;

        private Constants.RouteClassifications _routeClassification;

        private Constants.StatesAndTerritories _stateTerritory;

        public string RouteNumber
        {
            get
            {
                return _routeNumber;
            }
            set
            {
                _routeNumber = value;
            }
        }

        public List<Road> Roads { get; set; }

        public Constants.RouteClassifications RouteClassification
        {
            get
            {
                return _routeClassification;
            }
            set
            {
                _routeClassification = value;
            }
        }

        public Constants.StatesAndTerritories StateTerritory
        {
            get
            {
                return _stateTerritory;
            }
            set
            {
                _stateTerritory = value;
            }
        }

        public string Image { get; set; }

        public string ImageiOS { get; set; }

        public Route()
        {
            Roads = new List<Road>();
        }
    }
}
