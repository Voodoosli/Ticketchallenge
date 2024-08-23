using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiletProject.Model.Models.GetJourneys
{
    public class JourneysRequest
    {
        [JsonProperty("device-session")]
        public DeviceSession devicesession { get; set; }
        public string language { get; set; }
        public JourneysReqData data { get; set; }
    }

    public class JourneysReqData
    {
        [JsonProperty("origin-id")]
        public int originid { get; set; }

        [JsonProperty("destination-id")]
        public int destinationid { get; set; }

        [JsonProperty("departure-date")]
        public DateTime departuredate { get; set; }
    }

    public class DeviceSession
    {
        [JsonProperty("session-id")]
        public string sessionid { get; set; }

        [JsonProperty("device-id")]
        public string deviceid { get; set; }
    }

  




}
