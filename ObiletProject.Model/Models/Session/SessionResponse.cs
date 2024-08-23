using Newtonsoft.Json;

namespace ObiletProject.Model.Models.Session
{
   
    

    public class SessionData
    {
        [JsonProperty("session-id")]
        public string sessionid { get; set; }

        [JsonProperty("device-id")]
        public string deviceid { get; set; }
        public string affiliate { get; set; }

        [JsonProperty("device-type")]
        public int devicetype { get; set; }
        public string device { get; set; }

        [JsonProperty("ip-country")]
        public string ipcountry { get; set; }
    }

    public class SessionResponse
    {
        public string status { get; set; }
        public SessionData data { get; set; }
        public string message { get; set; }

        [JsonProperty("user-message")]
        public string usermessage { get; set; }

        [JsonProperty("api-request-id")]
        public string apirequestid { get; set; }
        public string controller { get; set; }

        [JsonProperty("client-request-id")]
        public string clientrequestid { get; set; }

        [JsonProperty("web-correlation-id")]
        public string webcorrelationid { get; set; }

        [JsonProperty("correlation-id")]
        public string correlationid { get; set; }
        public string parameters { get; set; }
    }





}
