using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ObiletProject.Model.Models.Session;

namespace ObiletProject.Extension.Validation
{
    public static class ValidationServices
    {
        public static void ConfigureValidationServices(this IServiceCollection services)
        {

            services.AddTransient<IValidator<SessionRequest>, SessionRequestValidator>();

 

        }
    }
}
