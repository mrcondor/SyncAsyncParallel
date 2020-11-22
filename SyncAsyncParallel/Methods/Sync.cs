﻿using SyncAsyncParallel.Class;
using System.Collections.Generic;
using System.Net;

namespace SyncAsyncParallel.Methods
{
    public class Sync
    {
        public static IEnumerable<WebSiteDataModel> RunDownloadSync()
        {
            var output = new List<WebSiteDataModel>();
            foreach (var page in Shared.GetTestsPages())
                output.Add(Shared.DownloadWebSiteSync(page));

            return output;
        }
    }
}


// ORIGINAL
//var output = new WebSiteDataModel();
//var client = new WebClient();

//output.WebSiteUrl = webSiteUrl;
//output.WebSiteData = client.DownloadString(webSiteUrl);

//return output;
