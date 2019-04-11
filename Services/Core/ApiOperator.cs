using System.IO;
using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Services.Core
{
    public class ApiOperator<T> where T : class
    {
        public List<T> GetApiResult(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string result = String.Empty;
            using(StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                result = reader.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<List<T>>(result);
        }
    }
}