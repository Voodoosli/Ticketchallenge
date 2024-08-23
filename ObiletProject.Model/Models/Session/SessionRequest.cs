using FluentValidation;
using Newtonsoft.Json;

namespace ObiletProject.Model.Models.Session
{
    public class SessionRequest
    {
        public int type { get; set; }
        public Connection connection { get; set; }
        public Browser browser { get; set; }


    }
    public class Browser
    {
        public string name { get; set; }
        public string version { get; set; }
    }

    public class Connection
    {
        [JsonProperty("ip-address")]
        public string ipaddress { get; set; }
        public string port { get; set; }
    }

    public class SessionRequestValidator : AbstractValidator<SessionRequest>
    {
        public SessionRequestValidator()
        {
            RuleFor(m => m.browser.name).NotEmpty().NotNull().WithMessage("Browser bilgisi eksik");
            RuleFor(m => m.browser.version).NotEmpty().NotNull().WithMessage("Browser bilgisi eksik");
            RuleFor(m => m.connection.ipaddress).NotEmpty().NotNull().WithMessage("Connection bilgisi eksik");
            RuleFor(m => m.connection.port).NotEmpty().NotNull().WithMessage("Connection bilgisi eksik");


        }
    }
}
