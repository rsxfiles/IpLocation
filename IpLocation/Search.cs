using System;
using Newtonsoft.Json;



namespace IpLocation
{
    static class Search
    {
        public static Result LookupIp(string ip)
        {
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    string address = "http://extreme-ip-lookup.com/json/" + ip;
                    var json = webClient.DownloadString(address);
                    return JsonConvert.DeserializeObject<Result>(json);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
           
        }

        public static Result MyIp()
        {
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    string address = "http://extreme-ip-lookup.com/json/";
                    var json = webClient.DownloadString(address);
                    return JsonConvert.DeserializeObject<Result>(json);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


        }
    }
}
