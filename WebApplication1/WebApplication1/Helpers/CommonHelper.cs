using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AlCoApp.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace AlCoApp.Helpers
{
    
    public class CommonHelper
    {
        public class HelpReader
        {
            public static string WebAppName
            {
                get
                {
                    // @System.Configuration.ConfigurationManager.ConnectionStrings["DConnectionString"]
                    return System.Configuration.ConfigurationManager.AppSettings["AppName"].ToString();
                }
            }
        }

        public class MediCalRESTService
        {
            readonly string uri = "https://data.acgov.org/resource/6vxh-qgkw.json";
            public List<MediCalLocModel> GetLoctionssAsync()
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    Task<String> response = httpClient.GetStringAsync(uri);
                    return JsonConvert.DeserializeObjectAsync<List<MediCalLocModel>>(response.Result).Result;
                }
            }
        }

        public class SSAOfficeRESTService
        {
            readonly string uri = "https://data.acgov.org/resource/2idn-uxp3.json";
            public List<SSAOfficeModel> GetLoctionssAsync()
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    Task<String> response = httpClient.GetStringAsync(uri);
                    return JsonConvert.DeserializeObjectAsync<List<SSAOfficeModel>>(response.Result).Result;
                }
            }
        }

        public class SeniorServiceProviders
        {
            readonly string uri = "https://data.acgov.org/resource/tauh-r5v2.json";

            public List<SeniorSevices> GetLoctionssAsync()
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    Task<String> response = httpClient.GetStringAsync(uri);
                    return JsonConvert.DeserializeObjectAsync<List<SeniorSevices>>(response.Result).Result;
                }
            }
        }
    }
}