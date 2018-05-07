namespace RestApiWrapper.Endpoints
{
    /// <summary>
    /// MetaWeather provides an API that delivers JSON over HTTPS for access to our data.
    /// </summary>
    public interface IMetaWeatherApi
    {
        /// <summary>
        /// Create query by location
        /// </summary>
        /// <param name="woeid">Where On Earth ID.</param>
        /// <returns>Request uri for query by location</returns>
        string QueryByLocation(string woeid);
    }
}
