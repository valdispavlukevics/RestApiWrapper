using RestApiWrapper.Endpoints;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RestApiWrapper
{
    /// <summary>
    /// Rest api endpoints wrapper
    /// </summary>
    public static class RestApiWrapper
    {
        /// <summary>
        /// Execute GET method in Rest endpoint
        /// </summary>
        /// <typeparam name="IRestApiEndpoint">Rest api endpoint</typeparam>
        /// <param name="action">Rest api request build method</param>
        /// <returns>Response</returns>
        public static async Task<HttpResponseMessage> Get<IRestApiEndpoint>(Func<IRestApiEndpoint, string> action)
        {
            HttpClient client = new HttpClient();
            var endpoint = (IRestApiEndpoint)EndpointFactory.Create<IRestApiEndpoint>(client);

            var requestUri = action(endpoint);
            var response = await client.GetAsync(requestUri);

            return response;
        }
    }
}
