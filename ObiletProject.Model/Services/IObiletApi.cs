using ObiletProject.Model.Commons;
using ObiletProject.Model.Models.BusLocations;
using ObiletProject.Model.Models.GetJourneys;
using ObiletProject.Model.Models.Session;

namespace ObiletProject.Model.Services
{
    public interface IObiletApi
    {
        Task<IReturnData<SessionResponse>> GetSession(SessionRequest data);
        Task<IReturnData<BusLocationsResponse>> GetBusLocations(BusLocationsRequest data);

        Task<IReturnData<JourneysResponse>> GetJourneys(JourneysRequest data);
    }
}
