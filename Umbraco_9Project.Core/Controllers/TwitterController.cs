using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;
using Umbraco_9Project.Core.ViewModel;

namespace Umbraco_9Project.Core.Controllers
{
    public class TwitterController : SurfaceController
    {
        public TwitterController(IUmbracoContextAccessor umbracoContextAccessor, 
            IUmbracoDatabaseFactory databaseFactory, 
            ServiceContext services, 
            AppCaches appCaches, 
            IProfilingLogger profilingLogger, 
            IPublishedUrlProvider publishedUrlProvider) 
            : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
        }

        public ActionResult GetTweets(string twitterHandle)
        {
            string PARTIAL_VIEW_FOLDER = "~/Views/Partials";
            var vm = new TwitterViewModel();
            vm.TwitterHandle = twitterHandle;

            try
            {
                var tweets = GetLastestTweets(twitterHandle, 3);
                vm.Json = tweets;
                vm.Error = false;
            }
            catch(Exception e)
            {
                vm.Error = true;
                vm.Message = e.Message + e.StackTrace;
            }

            return PartialView(PARTIAL_VIEW_FOLDER + "LastestTweets.cshtml", twitterHandle);

        }

        private string GetLastestTweets(string twitterHandle, int numberOfTweets)
        {
            var siteSettings = Umbraco.ContentQuery.ContentAtRoot().DescendantsOrSelfOfType("siteSettings").F
        }
    }
}
