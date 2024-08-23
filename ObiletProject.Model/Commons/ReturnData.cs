using Newtonsoft.Json.Converters;
using ObiletProject.Model.Enums;
using System.Net;
using System.Text.Json.Serialization;

namespace ObiletProject.Model.Commons
{
    public class ReturnData<T> : IReturnData<T>
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Status Status { get; set; } = Status.Success;
        public string Message { get; set; }
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        public T Data { get; set; }






    }
}
