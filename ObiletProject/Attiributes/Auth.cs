using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ObiletProject.Extension.Helper;
using ObiletProject.Model.Services;
using ObiletProject.Api;
using ObiletProject.Model.Models.Session;

namespace ObiletProject.Attiributes
{
    public class AuthAttribute : TypeFilterAttribute
    {
        public AuthAttribute(params object[] parameters) : base(typeof(AuthorizeFilter))
        {
            Arguments = new object[] { parameters };
        }
    }

    public class AuthorizeFilter : IAuthorizationFilter
    {
        readonly object[] _parameters;
        private readonly IObiletApi _obiletApi;

        public AuthorizeFilter(IObiletApi obiletApi, params object[] parameters)
        {
            _obiletApi = obiletApi;
            _parameters = parameters;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        { 
            try
            {
                UserSession userSession = new UserSession();
                var user = userSession.Get(context.HttpContext);
                var browserInfo = context.HttpContext.Request.Headers.UserAgent;
                

             
                if (user == null)
                {
                    var req = new SessionRequest
                    {
                        type=1,
                        connection = new Connection
                        {
                           ipaddress = context.HttpContext.Connection.RemoteIpAddress.ToString(),
                           port = context.HttpContext.Connection.RemotePort.ToString()
                        },
                        browser = new Browser
                        {
                            name = "Chrome",
                            version = "47.0.0.12"
                        }
                    };
                  
                    
                    var session =   _obiletApi.GetSession(req);
                    if (session.Result.Status != Model.Enums.Status.Error)
                    {
                        userSession.Set(session.Result.Data, context.HttpContext);
                    }


                }
               
            }
            catch (Exception ex)
            {
                throw new System.NotImplementedException();
            }
           
        }
    }
}
