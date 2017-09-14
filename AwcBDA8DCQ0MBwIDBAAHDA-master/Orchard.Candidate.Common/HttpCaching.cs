using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using Orchard.Candidate.Core.Models;
using System.Web;

namespace Orchard.Candidate.Common
{
    public static class HttpCaching
    {
        public static bool HttpCacheSet(this UserBlogPostModel userBlogPostModel)
        {
            HttpRuntime.Cache["userBlogPostCache"] = userBlogPostModel;
            return true;
        }
        public static UserBlogPostModel HttpCacheGet(this List<UserBlogPostModel> userBlogPostModel)
        {
            UserBlogPostModel userBlogPostMode = HttpRuntime.Cache["userBlogPostCache"] as UserBlogPostModel;
            return userBlogPostMode;
        }
    }
}
