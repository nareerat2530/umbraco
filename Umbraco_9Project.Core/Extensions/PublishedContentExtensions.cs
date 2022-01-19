using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Umbraco_9Project.Core.Extensions
{
    public static class  PublishedContentExtensions
    {
        public static string GetProductReference(this IPublishedContent content)
        {
            return content.Key.ToString();        }
    }
}
