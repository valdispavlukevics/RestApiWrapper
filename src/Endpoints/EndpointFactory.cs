using System;
using System.Net.Http;

namespace RestApiWrapper.Endpoints
{
    /// <summary>
    /// Simple endpoint factory
    /// </summary>
    internal static class EndpointFactory
    {
        /// <summary>
        /// Create instance of endpoint
        /// </summary>
        /// <typeparam name="TEndpoint">Endpoint interface</typeparam>
        /// <param name="client">HttpClient instance</param>
        /// <returns></returns>
        public static IRestApiEndpoint Create<TEndpoint>(HttpClient client)
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));

            var endpointType = typeof(TEndpoint);

            if (endpointType == typeof(IMetaWeatherApi))
            {
                return new MetaWeatherApi(client);
            }
            
            throw new NotImplementedException($"Api {endpointType.FullName} not implemented");
        }
    }
}
