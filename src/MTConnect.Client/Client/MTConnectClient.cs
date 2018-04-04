using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Serialization;

    using MTConnect.Client;

    public class MTConnectClient : IMTConnectClient
    {
        private Uri baseUrl;

        public MTConnectClient(string baseUri)
        {
            this.baseUrl = new Uri(baseUri);
        }

        public async Task<MTConnectDevicesType> ProbeAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var adapterClient = new MTConnectAdapter(this.baseUrl);
            return await Run<MTConnectDevicesType>(adapterClient.ProbeAsync, cancellationToken);
        }

        public async Task<MTConnectStreamsType> CurrentAsync(
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var adapterClient = new MTConnectAdapter(this.baseUrl);
            return await Run<MTConnectStreamsType>(adapterClient.CurrentAsync, cancellationToken);
        }

        public async Task<MTConnectStreamsType> SampleAsync(
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var adapterClient = new MTConnectAdapter(this.baseUrl);
            return await Run<MTConnectStreamsType>(adapterClient.SampleAsync, cancellationToken);
        }

        public async Task<MTConnectDevicesType> ProbeAsync(string deviceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            var adapterClient = new MTConnectAdapter(this.baseUrl) { DeviceName = deviceId };
            return await Run<MTConnectDevicesType>(adapterClient.ProbeDeviceAsync, cancellationToken);
        }

        public async Task<MTConnectStreamsType> SampleAsync(string deviceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            var adapterClient = new MTConnectAdapter(this.baseUrl) { DeviceName = deviceId };
            return await Run<MTConnectStreamsType>(adapterClient.DeviceSampleAsync, cancellationToken);
        }

        private static T DeserializeResults<T>(Stream resultStream)
        {
            T result;
            using (var reader = XmlReader.Create(resultStream))
            {
                var serializer = new XmlSerializer(typeof(T));
                result = (T)serializer.Deserialize(reader);
            }

            return result;
        }

        private async static Task<T> Run<T>(Func<CancellationToken, Task<Stream>> operation, CancellationToken token)
        {
            var resultStream = await operation(token);

            return DeserializeResults<T>(resultStream);
        }
    }
}
