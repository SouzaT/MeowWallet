﻿using MeowWalletCallback.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MeowWalletCallback.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public JObject Post(JObject jsonResult)
        {
            MeowWalletCallbackModel obj = JsonConvert.DeserializeObject<MeowWalletCallbackModel>(jsonResult.ToString());
            return jsonResult;
        }
    }
}