using MeowWalletCallback.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MeowWalletCallback.Controllers
{
    public class MeowWalletController : ApiController
    {
        [System.Web.Http.HttpPut]
        public JObject Post(JObject jsonResult)
        {
            MeowWalletCallbackModel obj = JsonConvert.DeserializeObject<MeowWalletCallbackModel>(jsonResult.ToString());
            obj.Ext_email = "vinamsn@msn.com";

            return jsonResult;
        }
    }
}