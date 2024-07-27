using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WonderCircuits.Security.Claims
{
    public class WonderClaimType
    {
        public WonderClaimType()
        {

        }
        
        public const string UserId = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/UserId";
        public const string UserName = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/UserName";
        public const string SiteId = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/SiteId";
        public const string SiteName = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/SiteName";

    }
}
