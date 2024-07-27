using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;

namespace WonderCircuits.Security.Claims
{
    public interface ICurrentPrincipalAccessor
    {
        ClaimsPrincipal Principal { get; }

        void Change(ClaimsPrincipal principal);
    }

    public static class ICurrentPrincipalAccessorExtensions
    {
        public static int GetCurrentUserId(this ICurrentPrincipalAccessor accessor)
        {
           var userId = accessor.Principal.FindFirst(WonderClaimType.UserId)?.Value;
           return Convert.ToInt32(userId);
        }
        public static string GetCurrentUserName(this ICurrentPrincipalAccessor accessor)
        {
            var userName = accessor.Principal.FindFirst(WonderClaimType.UserName)?.Value;
            return userName;
        }
        public static int GetCurrentSiteId(this ICurrentPrincipalAccessor accessor)
        {
            var siteId = accessor.Principal.FindFirst(WonderClaimType.SiteId)?.Value;
            return Convert.ToInt32(siteId);
        }
        public static string GetCurrentSiteName(this ICurrentPrincipalAccessor accessor)
        {
            var userName = accessor.Principal.FindFirst(WonderClaimType.SiteName)?.Value;
            return userName;
        }
    }
}
