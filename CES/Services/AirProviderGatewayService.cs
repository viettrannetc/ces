﻿using CES.Database.Context;
using CES.Model.Request;
using CES.Model.Response;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using CES.Constant;

namespace CES.Services
{
    /**
     * This class should be used for communicating external service only,
     * and the communication between Telstar with the 3rd party service can be achieved 
     * by HTTP request
     **/ 
	public class AirProviderGatewayService : IAirProvider
	{
        // db context
        private CesContext _context;

        public AirProviderGatewayService(CesContext context)
        {
            _context = context;
        }

        private string GetEndPoint()
        {
            var endpoint = _context.RouteConfigurations.FirstOrDefault(c => c.Key == AppConstant.SHIP_PROVIDER_URL);
            return endpoint.Value;
        }

        public List<RouteResponseModel> FindPath(RouteRequestModel request)
        {
            /**
              * Stub data for initializing the implementation, should be replaced with real data
              * @TODO: replace with the CURL request to external endpoint
              **/
            var routes = new List<RouteResponseModel>()
            {
                new RouteResponseModel()
                {
                    Start = "",
                    Destination = "",
                    Price = 3,
                    StartDate = new DateTime(),
                    Time = 20, // in hours
                    Transportation = Enums.Transportation.Car.ToString()
                },
                new RouteResponseModel()
                {
                    Start = "",
                    Destination = "",
                    Price = 10,
                    StartDate = new DateTime(),
                    Time = 4, // in hours
                    Transportation = Enums.Transportation.Airborne.ToString()
                }
            };
            return routes;
        }
    }
}
