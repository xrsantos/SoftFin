﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SoftFin.Vindi
{
    class RestConection
    {

        public HttpClient Conecta()
        {
            var cta = new HttpClient();

            TimeSpan span = new TimeSpan(0, 0, 1, 30, 0);
            cta.Timeout = span;


            //var apiUrlServer = ConfigurationManager.AppSettings["apiUrlServer"];
            var keyVindi = ConfigurationManager.AppSettings["keyVindi"].ToString();

            //cta.BaseAddress = new Uri(apiUrlServer);
            cta.DefaultRequestHeaders.Accept.Clear();
            cta.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var byteArray = Encoding.ASCII.GetBytes(keyVindi + ":");
            var header = new AuthenticationHeaderValue(
                       "Basic", Convert.ToBase64String(byteArray));
            cta.DefaultRequestHeaders.Authorization = header;
            return cta;
        }

    }
}
