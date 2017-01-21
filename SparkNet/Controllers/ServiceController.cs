using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using SparkNet.Models;
using SparkNet.Business;
using Newtonsoft.Json;

namespace SparkNet.Controllers
{
    public class ServiceController : ApiController
    {
        //Get the nested Menu item from DB.
        [HttpGet]
        public HttpResponseMessage Menu()
        {
            List<Menu> lstMenu = (new App()).GetMenu();
            var JsonData = JsonConvert.SerializeObject(lstMenu);

            var response = new HttpResponseMessage()
            {
                Content = new StringContent(JsonData, Encoding.UTF8, "application/json")
            };
            response.Headers.Add("Access-Control-Allow-Origin", "*");
            return response;
        }
       

    }
}
