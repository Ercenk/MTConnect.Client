namespace Client
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IMTConnectClient
    {
        Task<MTConnectDevicesType> ProbeAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}