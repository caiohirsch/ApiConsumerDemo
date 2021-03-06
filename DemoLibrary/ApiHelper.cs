using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class ApiHelper
    {
        public static HttpClient ApiCliente { get; set; }

        public static void InitializeClient()
        {
            ApiCliente = new HttpClient();
            ApiCliente.DefaultRequestHeaders.Accept.Clear();
            ApiCliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
