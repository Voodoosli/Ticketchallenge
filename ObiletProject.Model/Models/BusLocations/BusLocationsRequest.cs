using FluentValidation;
using Newtonsoft.Json;
using ObiletProject.Model.Models.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiletProject.Model.Models.BusLocations
{
    public class BusLocationsRequest
    {
        public string data { get; set; }

        [JsonProperty("device-session")]
        public DeviceSession devicesession { get; set; }
        public DateTime date { get; set; }
        public string language { get; set; }
    }

    public class DeviceSession
    {
        [JsonProperty("session-id")]
        public string sessionid { get; set; }

        [JsonProperty("device-id")]
        public string deviceid { get; set; }
    }


    public class BusLocationsRequestValidator : AbstractValidator<BusLocationsRequest>
    {
        public BusLocationsRequestValidator()
        {
            RuleFor(m => m.devicesession.sessionid).NotEmpty().NotNull().WithMessage("session bilgisi eksik");
            RuleFor(m => m.devicesession.deviceid).NotEmpty().NotNull().WithMessage("session bilgisi eksik");
          


        }
    }




}
