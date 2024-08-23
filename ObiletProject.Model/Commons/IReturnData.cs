using ObiletProject.Model.Enums;
using System.Net;

namespace ObiletProject.Model.Commons
{
    public interface IReturnData<T>
    {
        Status Status { get; set; }
        string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        T Data { get; set; }

    }
}
