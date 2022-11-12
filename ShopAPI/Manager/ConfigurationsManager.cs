﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Manager
{
    public class ConfigurationsManager
    {
        public string Token { get; set; }
        public string ConnectionString { get; set; }
        public string ApiUrl { get; set; }
        public string SiteUrl { get; set; }
        public string redirectAfterConfirmMail { get; set; }

        public ConfigurationsManager()
        {

            using (StreamReader r = new System.IO.StreamReader("appsettings.json"))
            {
                string json = r.ReadToEnd();

                dynamic item = JsonConvert.DeserializeObject(json);

                ConnectionString = item.DatabaseSettings.ConnectionString;
                ApiUrl = item.URLs.ApiUrl;
                SiteUrl = item.URLs.siteUrl;
                redirectAfterConfirmMail = item.URLs.redirectAfterConfirmMail;
            }
        }

    }

}
