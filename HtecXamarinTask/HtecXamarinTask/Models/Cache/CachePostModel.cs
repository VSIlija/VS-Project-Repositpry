using System;
using System.Collections.Generic;

namespace HtecXamarinTask.Models.Cache
{
    public class CachePostModel
    {
        /// <summary>
        /// List of posts from cache.
        /// </summary>
        public List<PostModel> Posts { get; set; }

        /// <summary>
        /// DateTime of last saved data in cache.
        /// </summary>
        public DateTime Date { get; set; }
    }
}
