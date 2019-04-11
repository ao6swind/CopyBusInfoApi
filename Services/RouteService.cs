using System;
using Services.Core;
using Models;
using System.Collections.Generic;

namespace Services
{
    public class RouteService : CoreOperator<Route>
    {
        public void Backup()
        {
            string url = @"http://data.ntpc.gov.tw/od/data/api/67BB3C2B-E7D1-43A7-B872-61B2F082E11B?$format=json";
            List<Route> routes = GetApiResult(url);

            foreach(Route route in routes)
            {
                if(Find(route.Id) == null)
                {
                    Create(route);
                }
                else
                {
                    Update(route.Id, route);
                }
            }
        }
    }
}
