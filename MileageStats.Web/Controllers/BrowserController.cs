﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MileageStats.Web.MobileProfiler;

namespace MileageStats.Web.Controllers
{
    public class BrowserController : Controller
    {
        private readonly MobileCapabilitiesProvider mobileCapabilitiesProvider;

        public BrowserController(MobileCapabilitiesProvider mobileCapabilitiesProvider)
        {
            this.mobileCapabilitiesProvider = mobileCapabilitiesProvider;
        }

        //
        // GET: /Browser/

        public ActionResult Index()
        {
            var caps = mobileCapabilitiesProvider.GetBrowserCapabilities(this.Request);
            caps.Add(new KeyValuePair<string, string>("_Request.Browser.ScreenPixelsWidth", Request.Browser.ScreenPixelsWidth.ToString()));
            return View(caps);
        }

    }
}
