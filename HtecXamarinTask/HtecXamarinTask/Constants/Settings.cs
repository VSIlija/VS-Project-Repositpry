using System;

namespace HtecXamarinTask.Constants
{
    public static class Settings
    {
        public static readonly string TipycodeBaseUrl = "https://jsonplaceholder.typicode.com";

        public static readonly TimeSpan CacheDurationMinutes = TimeSpan.FromMinutes(1);

        public static readonly string NavigateBack = "..";

        public static class CacheKeyes
        {
            public static readonly string Posts = "Posts";
        }
    }
}
