﻿using Microsoft.Identity.Client;
using Microsoft.PowerPlatform.Dataverse.Client.Auth.TokenCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.PowerPlatform.Dataverse.Client.Auth
{
    /// <summary>
    /// Class used to describe the outcome of the execute authentication process.
    /// </summary>
    internal class ExecuteAuthenticationResults
    {
        public AuthenticationResult MsalAuthResult { get; set; }
        public Uri TargetServiceUrl { get; set; }
        public object MsalAuthClient { get; set; }
        public string Authority { get; set; }
        public string Resource { get; set; }
        public IAccount UserIdent { get; set; }
        public MemoryBackedTokenCache MemTokenCache { get; set; }


        internal string GetAuthTokenAndProperties(out AuthenticationResult msalAuthResult, out Uri targetServiceUrl, out object msalAuthClient, out string authority, out string resource, out IAccount userIdent, out MemoryBackedTokenCache memoryBackedTokenCache)
        {
            msalAuthResult = MsalAuthResult;
            targetServiceUrl = TargetServiceUrl;
            msalAuthClient = MsalAuthClient;
            authority = Authority;
            resource = Resource;
            userIdent = UserIdent;
            memoryBackedTokenCache = MemTokenCache;

            return MsalAuthResult.AccessToken;
        }
    }
}
