namespace Client
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IMTConnectClient
    {
        Task<MTConnectDevicesType> ProbeAsync(CancellationToken cancellationToken = default(CancellationToken));

        Task<MTConnectStreamsType> CurrentAsync(
            CancellationToken cancellationToken = default(CancellationToken));

        Task<MTConnectStreamsType> SampleAsync(
            CancellationToken cancellationToken = default(CancellationToken));

        Task<MTConnectDevicesType> ProbeAsync(string deviceId, CancellationToken cancellationToken = default(CancellationToken));

        Task<MTConnectStreamsType> SampleAsync(string deviceId, CancellationToken cancellationToken = default(CancellationToken));
    }
}