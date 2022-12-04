namespace SimpleRedirects.Core.Options
{
    public class SimpleRedirectsOptions
    {
        public const string Position = "SimpleRedirects";

        public bool CacheEnabled {get; set;} = true;
        public int CacheDuration {get; set;} = 86400;
        public bool OnlyRedirectOn404 { get; set; } = false;
        public bool IgnoreQueryString { get; set; } = false;
        public bool PreserveQueryString { get; set; } = false;
    }
}