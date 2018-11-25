using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WebMVC
{
    public class GlobalVariable
    {
        public static HttpClient WebApiPedido = new HttpClient();
        static GlobalVariable()
        {
            WebApiPedido.BaseAddress = new Uri("http://localhost:59073/api/");
            WebApiPedido.DefaultRequestHeaders.Clear();
            WebApiPedido.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}