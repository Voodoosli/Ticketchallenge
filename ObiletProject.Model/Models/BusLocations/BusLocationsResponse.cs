using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiletProject.Model.Models.BusLocations
{
    

    public class BusLocationsData
    {
        public int id { get; set; }

        [JsonProperty("parent-id")]
        public int parentid { get; set; }
        public string type { get; set; }
        public string name { get; set; }

        [JsonProperty("geo-location")]
        public GeoLocation geolocation { get; set; }
        public int zoom { get; set; }

        [JsonProperty("tz-code")]
        public string tzcode { get; set; }

        [JsonProperty("weather-code")]
        public string weathercode { get; set; }
        public int rank { get; set; }

        [JsonProperty("reference-code")]
        public string referencecode { get; set; }

        [JsonProperty("city-id")]
        public int cityid { get; set; }

        [JsonProperty("reference-country")]
        public string referencecountry { get; set; }

        [JsonProperty("country-id")]
        public int countryid { get; set; }
        public string keywords { get; set; }

        [JsonProperty("city-name")]
        public string cityname { get; set; }
        public object languages { get; set; }

        [JsonProperty("country-name")]
        public string countryname { get; set; }
        public string code { get; set; }

        [JsonProperty("show-country")]
        public bool showcountry { get; set; }

        [JsonProperty("area-code")]
        public string areacode { get; set; }

        [JsonProperty("long-name")]
        public string longname { get; set; }

        [JsonProperty("is-city-center")]
        public bool iscitycenter { get; set; }
    }

    public class GeoLocation
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int zoom { get; set; }
    }

    public class BusLocationsResponse
    {
        public string status { get; set; }
        public List<BusLocationsData> data { get; set; }
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
