using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ConnectToApi
{
   public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; } 

        public static void initializeClient()
        {
            ApiClient =  new HttpClient();
            

            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


        }
    }
}
