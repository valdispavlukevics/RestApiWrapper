using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace RestApiWrapper.Endpoints
{
    /// <summary>
    /// MetaWeather provides an API that delivers JSON over HTTPS for access to our data.
    /// </summary>
    internal class MetaWeatherApi : BaseApiEndpoint, IMetaWeatherApi, IRestApiEndpoint
    {
        private HttpClient _client;

        public MetaWeatherApi(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));

            _client.BaseAddress = BaseAddress;   
        }

        protected override Uri BaseAddress => new Uri("https://www.metaweather.com/api/");

        /// <summary>
        /// Create query by location
        /// </summary>
        /// <param name="woeid">Where On Earth ID.</param>
        /// <returns>Request uri for query by location</returns>
        public string QueryByLocation(string woeid)
        {
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return $"location/{woeid}/";
        }
    }
}
