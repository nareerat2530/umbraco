using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Extensions;
using Umbraco_9Project.Core.ViewModel;
using Umbraco_9Project.ModelBuilder.ModelsBuilder;

namespace Umbraco_9Project.Core.Controllers
{
    public class ProductsController :Umbraco.Cms.Web.Common.Controllers.UmbracoApiController
    {
        private IUmbracoContextAccessor _context;

        private IPublishedValueFallback _publishedValueFallback;
       
        public ProductsController(IUmbracoContextAccessor context,


            IUmbracoContextAccessor umbracoContextAccessor,
            IPublishedValueFallback publishedValueFallback
               )
        {
            _context = context;
        }

      

        //[HttpGet("")]
        public IActionResult Products()
        {
            var cache = _context.GetRequiredUmbracoContext();
            var home = cache.Content.GetAtRoot().DescendantsOrSelf<HomePage>().First();
            var listing = home.Products;
            return Ok(listing);
        }
    }
}
