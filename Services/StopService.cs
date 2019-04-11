using System;
using Services.Core;
using Models;
using System.Collections.Generic;

namespace Services
{
    public class StopService : CoreOperator<Stop>
    {
        public void Backup()
        {
            string url = @"http://data.ntpc.gov.tw/od/data/api/62519D6B-9B6D-43E1-BFD7-D66007005E6F?$format=json";
            List<Stop> stops = GetApiResult(url);

            foreach(Stop stop in stops)
            {
                if(Find(stop.Id) == null)
                {
                    Create(stop);
                }
                else
                {
                    Update(stop.Id, stop);
                }
            }
        }
    }
}