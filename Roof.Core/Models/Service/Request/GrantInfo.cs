using System;

namespace Roof.Core
{
    public class GrantInfo
    {
        public string client_id { get; set; }
        public string client_secret { get; set; }
        public string audience { get; set; }
        public string grant_type { get; set; }
    }

    public class AuthInfo
    {
        public string token_url { get; set; }
        public GrantInfo GrantInfo { get; set; }
    }
}
