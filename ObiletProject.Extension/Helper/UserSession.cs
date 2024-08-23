using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using ObiletProject.Model.Models.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiletProject.Extension.Helper
{
    public class UserSession
    {

        public SessionResponse Get(HttpContext context)
        {
            SessionResponse User;
            if (context.Session.GetString("User") != null)
            {
                User = JsonConvert.DeserializeObject<SessionResponse>(context.Session.GetString("User").ToString());
                return User;
            }
            return null;
        }

        public bool Set(SessionResponse model, HttpContext context)
        {
            context.Session.SetString("User", JsonConvert.SerializeObject(model));
            return true;
        }
        public bool Delete(HttpContext context)
        {
            context.Session.Remove("User");
            return true;
        }
    }
}
