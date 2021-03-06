// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace MTConnect.Client
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// MTConnect Adapter REST API 1.3.1
    /// </summary>
    public partial interface IMTConnectAdapter : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// An xpath expression specifying the components and/or data items to
        /// include in the sample.
        /// </summary>
        string Path { get; set; }

        /// <summary>
        /// This parameter requests Events, Condition, and Samples starting at
        /// this sequence number.
        /// </summary>
        int? FromProperty { get; set; }

        /// <summary>
        /// The maximum number of Events, Condition, and Samples to consider,
        /// see detailed explanation below.
        /// </summary>
        int? Count { get; set; }

        /// <summary>
        /// Samples, Events, and Condition to the client application pausing
        /// for interval milliseconds between each part.
        /// </summary>
        int? Interval { get; set; }

        /// <summary>
        /// the sequence number following the largest sequence number (highest
        /// sequence number + 1) of all the Events, Condition, and Samples
        /// considered when collecting the results.
        /// </summary>
        int? NextSequence { get; set; }

        /// <summary>
        /// Name of the device
        /// </summary>
        string DeviceName { get; set; }

        /// <summary>
        /// Specifies the MTConnect protocol sequence number.
        /// </summary>
        int? At { get; set; }

        /// <summary>
        /// Asset type
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// ID of the asset
        /// </summary>
        string AssetId { get; set; }


        /// <summary>
        /// Lists this Agent’s devices and all the devices’ components and data
        /// items being collected
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Stream>> ProbeWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Lists this Agents devices and all the devices components and data
        /// items being collected
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Stream>> ProbeDeviceWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieve the values for a component.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Stream>> SampleWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieve the values for a component
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Stream>> DeviceSampleWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieve the values for a component
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Stream>> CurrentWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieve the values for a component
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Stream>> DeviceCurrentWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieve the available assets
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Stream>> AssetsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieve the available assets
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Stream>> AssetDetailsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
