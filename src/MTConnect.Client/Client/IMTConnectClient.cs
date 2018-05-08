namespace Client
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IMTConnectClient
    {
        Uri Uri { get; }

        Task<MTConnectDevicesType> ProbeAsync(CancellationToken cancellationToken = default(CancellationToken));


        Task<MTConnectDevicesType> ProbeAsync(string deviceId, CancellationToken cancellationToken = default(CancellationToken));

        Task<MTConnectStreamsType> CurrentAsync(string deviceId = "", string path = "", 
            int? interval = null, int? at = null,
            CancellationToken cancellationToken = default(CancellationToken));
        
        Task<MTConnectStreamsType> SampleAsync(string deviceId = "", string path = "", int? from = null, 
            int? count = null, int? interval = null, int? nextSequence = null,
            CancellationToken cancellationToken = default(CancellationToken));

    }
}