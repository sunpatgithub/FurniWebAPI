using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

//using OnlineTrackingSystem.Domain.Entities;
//using OnlineTrackingSystem.Service.Models;
//using OnlineTrackingSystem.Service.Utils;

namespace Furni.WebAPI.Provider
{
    // [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated(); // 
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            try
            {

                // ResponseDTO response = ActiveDirectroryAuthenticationHelper.GetAuthenticated(context.UserName , password);
                var props = new AuthenticationProperties(new Dictionary<string, string>
                                {
                                   {
                                    "userdisplayname", context.UserName
                                   },
                                   {
                                     "role", "admin"
                                   }
                                });

                //var props = new AuthenticationProperties("sunil",)

                var ticket = new AuthenticationTicket(identity, props);
                context.Validated(ticket);

                /*
                using (var cnAPIEntities = new CNAPIEntities())
                {
                    if (cnAPIEntities != null)
                    {
                        var user = cnAPIEntities.UserRegisters.ToList();
                        var admin = cnAPIEntities.AdminUsers.ToList();
                        if (user != null)
                        {
                            string password = context.Password;
                            var UserDmin = admin.Find(u => u.UserADID == context.UserName);
                            if (UserDmin != null)
                            {
                                // ResponseDTO response = ActiveDirectroryAuthenticationHelper.GetAuthenticated(context.UserName , password);
                                var props = new AuthenticationProperties(new Dictionary<string, string>
                                {
                                   {
                                    "userdisplayname", context.UserName
                                   },
                                   {
                                     "role", "admin"
                                   }
                                });

                                var ticket = new AuthenticationTicket(identity, props);
                                context.Validated(ticket);

                            }
                            else if(!string.IsNullOrEmpty(user.Where(u => u.EmailAddress == context.UserName && u.Password == password).FirstOrDefault().FirstName))
                            {
                               // identity.AddClaim(new Claim("Age", "16"));

                                var props = new AuthenticationProperties(new Dictionary<string, string>
                                {
                                  {
                                    "userdisplayname", context.UserName
                                  },
                                  {
                                     "role", "user"
                                  }
                                });

                                var ticket = new AuthenticationTicket(identity, props);
                                context.Validated(ticket);
                            }
                          
                            else
                            {
                                context.SetError("invalid_grant", "Provided username and password is incorrect");
                                context.Rejected();
                            }
                        }
                    }
                    else
                    {
                        context.SetError("invalid_grant", "Provided username and password is incorrect");
                        context.Rejected();
                    }
                    return;
                }
                
                 */

            }
            catch (Exception ex)
            {
                return;
            }


        }
    }
}