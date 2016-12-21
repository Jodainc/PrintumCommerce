using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using PrintumCommerce.Models;
using PrintumCommerce.Areas.api.Models;

namespace PrintumCommerce.Providers
{
    public class ApplicationOAuthProvider : OAuthAuthorizationServerProvider
    {
        private readonly string _publicClientId;

        public ApplicationOAuthProvider(string publicClientId)
        {
            if (publicClientId == null)
            {
                throw new ArgumentNullException("publicClientId");
            }

            _publicClientId = publicClientId;
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var userManager = context.OwinContext.GetUserManager<ApplicationUserManager>();

            ApplicationUser user = await userManager.FindAsync(context.UserName, context.Password);

            if (user == null)
            {
                context.SetError("invalid_grant", "The user name or password is incorrect.");
                return;
            }

            ClaimsIdentity oAuthIdentity = await user.GenerateUserIdentityAsync(userManager,
               OAuthDefaults.AuthenticationType);
            ClaimsIdentity cookiesIdentity = await user.GenerateUserIdentityAsync(userManager,
                CookieAuthenticationDefaults.AuthenticationType);

            AuthenticationProperties properties = CreateProperties(user.UserName);
            AuthenticationTicket ticket = new AuthenticationTicket(oAuthIdentity, properties);
            context.Validated(ticket);
            context.Request.Context.Authentication.SignIn(cookiesIdentity);
        }
        private DBPrintumContext db = new DBPrintumContext();
        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {

            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }


            return Task.FromResult<object>(null);

        }

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            // Resource owner password credentials does not provide a client ID.
            /*
            var q = from r in db.Users
                    where r.UserName == context.
                    select new Users
                    {
                        UserName = r.UserName,
                        troll = r.troll,
                        UserId = r.UserId
                    };
            int value = 0;
            foreach (Users item in q.ToList())
            {
                value = item.troll;
            }
            if (value == 1)
            {
         
            }
            else
            {

            }
            */
            context.Parameters.ToList();
            string values="";
            foreach (var item in context.Parameters.ToList())
            {
                if (item.Key.Equals("username"))
                {
                    values = item.Value[0];
                }
            }

            var q = from r in db.Users
                    where r.UserName == values
                    select new Areas.api.Models.User
                    {
                        UserName = r.UserName,
                        troll = r.troll,
                        UserId = r.UserId
                    };
            int value = 0;
            foreach (Areas.api.Models.User item in q.ToList())
            {
                value = item.troll;
            }
            if (value == 1)
            {
                if (context.ClientId == null)
                {
                    context.Validated();
                }

            }
            return Task.FromResult<object>(null);
        }

        public override Task ValidateClientRedirectUri(OAuthValidateClientRedirectUriContext context)
        {
            if (context.ClientId == _publicClientId)
            {
                Uri expectedRootUri = new Uri(context.Request.Uri, "/");

                if (expectedRootUri.AbsoluteUri == context.RedirectUri)
                {
                    context.Validated();
                }
            }

            return Task.FromResult<object>(null);
        }

        public static AuthenticationProperties CreateProperties(string userName)
        {
            IDictionary<string, string> data = new Dictionary<string, string>
            {
                { "userName", userName }
            };
            return new AuthenticationProperties(data);
        }
    }
}