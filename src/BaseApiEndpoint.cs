using System;

namespace RestApiWrapper
{
    /// <summary>
    /// Base endpoint
    /// </summary>
    internal abstract class BaseApiEndpoint
    {
        /// <summary>
        /// Endpoint base address
        /// </summary>
        protected abstract Uri BaseAddress { get; }
    }
}
