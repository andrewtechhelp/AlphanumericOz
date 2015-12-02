using AlphanumericOz.Core.Data;
using AlphanumericOz.Core.Models;
using System;
using System.Collections.Generic;

namespace AlphanumericOz.Core.Services
{
    public class RoutesGenesisService : IRoutesGenesisService
    {
        public List<Route> GenerateSampleRouteData()
        {
            return new List<Route>
            {
                new Route
                {
                    Id = Guid.NewGuid().ToString(),
                    RouteNumber = "M1",
                    Image = "res:m1.png",
                    RouteClassification = Constants.RouteClassifications.AlphanumericM,
                    StateTerritory = Constants.StatesAndTerritories.QLD,
                    Roads = new List<Road>
                    {
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Bruce Highway"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Gympie Arterial Road"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Gateway Motorway"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Pacific Motorway"
                        },
                    }
                },

                new Route
                {
                    Id = Guid.NewGuid().ToString(),
                    RouteNumber = "M2",
                    Image = "res:m2.png",
                    RouteClassification = Constants.RouteClassifications.AlphanumericM,
                    StateTerritory = Constants.StatesAndTerritories.QLD,
                    Roads = new List<Road>
                    {
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Gateway Motorway"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Logan Motorway"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Ipswich Motorway"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Warrego Highway"
                        },
                    }
                },

                new Route
                {
                    Id = Guid.NewGuid().ToString(),
                    RouteNumber = "M3",
                    Image = "res:m3.png",
                    RouteClassification = Constants.RouteClassifications.AlphanumericM,
                    StateTerritory = Constants.StatesAndTerritories.QLD,
                    Roads = new List<Road>
                    {
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Gympie Arterial Road"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Inner City Bypass"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Hale Street"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Coronation Drive"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Pacific Motorway"
                        },
                    }
                },

                new Route
                {
                    Id = Guid.NewGuid().ToString(),
                    RouteNumber = "M4",
                    Image = "res:m4.png",
                    RouteClassification = Constants.RouteClassifications.AlphanumericM,
                    StateTerritory = Constants.StatesAndTerritories.QLD,
                    Roads = new List<Road>
                    {
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Port of Brisbane Motorway"
                        },
                    }
                },

                new Route
                {
                    Id = Guid.NewGuid().ToString(),
                    RouteNumber = "M5",
                    Image = "res:m5.png",
                    RouteClassification = Constants.RouteClassifications.AlphanumericM,
                    StateTerritory = Constants.StatesAndTerritories.QLD,
                    Roads = new List<Road>
                    {
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Legacy Way Tunnel"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Western Freeway"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Centenary Motorway"
                        },
                    }
                },
                new Route
                {
                    Id = Guid.NewGuid().ToString(),
                    RouteNumber = "M6",
                    Image = "res:m6.png",
                    RouteClassification = Constants.RouteClassifications.AlphanumericM,
                    StateTerritory = Constants.StatesAndTerritories.QLD,
                    Roads = new List<Road>
                    {
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Logan Motorway"
                        },
                    }
                },

                new Route
                {
                    Id = Guid.NewGuid().ToString(),
                    RouteNumber = "M7",
                    Image = "res:m7.png",
                    RouteClassification = Constants.RouteClassifications.AlphanumericM,
                    StateTerritory = Constants.StatesAndTerritories.QLD,
                    Roads = new List<Road>
                    {
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "East - West Arterial Road"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Airport Link Tunnel"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Clem Jones Tunnel (Clem7)"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Ipswich Motorway"
                        },
                    }
                },

                new Route
                {
                    Id = Guid.NewGuid().ToString(),
                    RouteNumber = "Metroad 2",
                    Image = "res:metroad2.png",
                    RouteClassification = Constants.RouteClassifications.Metroad,
                    StateTerritory = Constants.StatesAndTerritories.QLD,
                    Roads = new List<Road>
                    {
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Granard Road"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Riawena Road"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Kessels Road"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Mt Gravatt - Capalaba Road"
                        },
                    }
                },

                new Route
                {
                    Id = Guid.NewGuid().ToString(),
                    RouteNumber = "Metroad 5",
                    Image = "res:metroad5.png",
                    RouteClassification = Constants.RouteClassifications.Metroad,
                    StateTerritory = Constants.StatesAndTerritories.QLD,
                    Roads = new List<Road>
                    {
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Stafford Road"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "South Pine Road"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Wardell Street"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Stewart Road"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Elimatta Drive"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Jubilee Terrace"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Macgregor Terrace"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Boundary Road"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Rouen Road"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Frederick Street"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Mount Coot-tha Road"
                        },
                    }
                },

                new Route
                {
                    Id = Guid.NewGuid().ToString(),
                    RouteNumber = "National Route 13",
                    Image = "res:nr13.png",
                    RouteClassification = Constants.RouteClassifications.NationalRoute,
                    StateTerritory = Constants.StatesAndTerritories.QLD,
                    Roads = new List<Road>
                    {
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Beaudesert Road"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Mount Lindesay Highway"
                        },
                    }
                },

                new Route
                {
                    Id = Guid.NewGuid().ToString(),
                    RouteNumber = "A3",
                    Image = "res:a3.png",
                    RouteClassification = Constants.RouteClassifications.AlphanumericA,
                    StateTerritory = Constants.StatesAndTerritories.QLD,
                    Roads = new List<Road>
                    {
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Gympie Road"
                        },
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Lutwyche Road"
                        },
                    }
                },

                new Route
                {
                    Id = Guid.NewGuid().ToString(),
                    RouteNumber = "A5",
                    Image = "res:a5.png",
                    RouteClassification = Constants.RouteClassifications.AlphanumericA,
                    StateTerritory = Constants.StatesAndTerritories.QLD,
                    Roads = new List<Road>
                    {
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Centenary Highway"
                        },
                    }
                },

                new Route
                {
                    Id = Guid.NewGuid().ToString(),
                    RouteNumber = "A7",
                    Image = "res:a7.png",
                    RouteClassification = Constants.RouteClassifications.AlphanumericA,
                    StateTerritory = Constants.StatesAndTerritories.QLD,
                    Roads = new List<Road>
                    {
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Ipswich Road"
                        },
                    }
                },

                new Route
                {
                    Id = Guid.NewGuid().ToString(),
                    RouteNumber = "M15",
                    Image = "res:m15.png",
                    RouteClassification = Constants.RouteClassifications.AlphanumericM,
                    StateTerritory = Constants.StatesAndTerritories.QLD,
                    Roads = new List<Road>
                    {
                        new Road
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = "Cunningham Highway"
                        },
                    }
                },
            };
        }
    }
}