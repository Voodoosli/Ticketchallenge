using AutoMapper.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ObiletProject.Model.Commons;
using ObiletProject.Model.Config;
using ObiletProject.Model.Enums;
using ObiletProject.Model.Models.BusLocations;
using ObiletProject.Model.Models.GetJourneys;
using ObiletProject.Model.Models.Session;
using ObiletProject.Model.Services;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObiletProject.Api
{
    public class ObiletApi : IObiletApi
    {

        private readonly RestClient client;
        public ObiletApi()
        { 
            client = new RestClient(ObiletConfig.Host);
           
        }

        public async Task<IReturnData<SessionResponse>> GetSession(SessionRequest data)
        {
            var result = new ReturnData<SessionResponse>();
            try
            {
                var request = new RestRequest("/client/getsession", Method.Post);
                var json = JsonConvert.SerializeObject(data); 
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Basic JEcYcEMyantZV095WVc3G2JtVjNZbWx1");
                request.AddStringBody(json, DataFormat.Json);
             
                var response = await client.ExecuteAsync(request);
                if (string.IsNullOrEmpty(response.Content))
                {
                    result.Status = Status.Error;
                    result.StatusCode = System.Net.HttpStatusCode.NoContent;
                    return result;
                }

                var res = JsonConvert.DeserializeObject<SessionResponse>(response.Content);
                result.Data = res;

                result.Status = Status.Success;
                result.StatusCode = System.Net.HttpStatusCode.OK;
                return result;
            }
            catch (Exception)
            {
                result.Status = Status.Error;
                result.StatusCode = System.Net.HttpStatusCode.BadRequest;
                return result;
            }
        }  

        public async Task<IReturnData<BusLocationsResponse>> GetBusLocations(BusLocationsRequest data)
        {
            var result = new ReturnData<BusLocationsResponse>();
            try
            {
                var request = new RestRequest("/location/getbuslocations", Method.Post);
                var json = JsonConvert.SerializeObject(data);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Basic JEcYcEMyantZV095WVc3G2JtVjNZbWx1");
                request.AddStringBody(json, DataFormat.Json);
                var response = await client.ExecuteAsync(request);
                if (string.IsNullOrEmpty(response.Content))
                {
                    result.Status = Status.Error;
                    result.StatusCode = System.Net.HttpStatusCode.NoContent;
                    return result;
                }

                var res = JsonConvert.DeserializeObject<BusLocationsResponse>(response.Content);
                result.Data = res;

                result.Status = Status.Success;
                result.StatusCode = System.Net.HttpStatusCode.OK;
                return result;
            }
            catch (Exception)
            {
                result.Status = Status.Error;
                result.StatusCode = System.Net.HttpStatusCode.BadRequest;
                return result;
            }
        }

        public async Task<IReturnData<JourneysResponse>> GetJourneys(JourneysRequest data)
        {
            var result = new ReturnData<JourneysResponse>();
            try
            {
                var request = new RestRequest("/journey/getbusjourneys", Method.Post);
                var json = JsonConvert.SerializeObject(data);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Basic JEcYcEMyantZV095WVc3G2JtVjNZbWx1");
                request.AddStringBody(json, DataFormat.Json);
                var response = await client.ExecuteAsync(request);
                if (string.IsNullOrEmpty(response.Content))
                {
                    result.Status = Status.Error;
                    result.StatusCode = System.Net.HttpStatusCode.NoContent;
                    return result;
                }

                var res = JsonConvert.DeserializeObject<JourneysResponse>(response.Content);
                result.Data = res;

                result.Status = Status.Success;
                result.StatusCode = System.Net.HttpStatusCode.OK;
                return result;
            }
            catch (Exception)
            {
                result.Status = Status.Error;
                result.StatusCode = System.Net.HttpStatusCode.BadRequest;
                return result;
            }
        }

        
       
    }
}
