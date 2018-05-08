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

        public MTConnectClient(Uri uri)
        {
            this.baseUrl = uri;
        }

        public Uri Uri => this.baseUrl;

        public async Task<MTConnectDevicesType> ProbeAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var adapterClient = new MTConnectAdapter(this.baseUrl);
            return await Run<MTConnectDevicesType>(adapterClient.ProbeAsync, cancellationToken);
        }

        public async Task<MTConnectDevicesType> ProbeAsync(string deciceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            var adapterClient = new MTConnectAdapter(this.baseUrl) {DeviceName = deciceId};

            return await Run<MTConnectDevicesType>(adapterClient.ProbeDeviceAsync, cancellationToken);
        }

        public async Task<MTConnectStreamsType> CurrentAsync(string deviceId = "", string path = "", int? interval = null, int? at = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var adapterClient = new MTConnectAdapter(this.baseUrl)
            {
                DeviceName = deviceId == string.Empty ? null : deviceId,
                Path = path == string.Empty ? null : path,
                Interval = interval,
                At = at
            };

            if (deviceId == string.Empty)
            {
                return await Run<MTConnectStreamsType>(adapterClient.CurrentAsync, cancellationToken);
            }
            return await Run<MTConnectStreamsType>(adapterClient.DeviceCurrentAsync, cancellationToken);
        }

        public async Task<MTConnectStreamsType> SampleAsync(string deviceId = "", string path = "", int? @from = null, int? count = null, int? interval = null,
            int? nextSequence = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var adapterClient = new MTConnectAdapter(this.baseUrl)
            {
                DeviceName = deviceId == string.Empty ? null : deviceId,
                Path = path == string.Empty ? null : path,
                FromProperty = @from,
                Count = count,
                Interval = interval,
                NextSequence = nextSequence
            };

            if (deviceId == string.Empty)
            {
                return await Run<MTConnectStreamsType>(adapterClient.SampleAsync, cancellationToken);
            }
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

        private static async Task<T> Run<T>(Func<CancellationToken, Task<Stream>> operation, CancellationToken token)
        {
            var resultStream = await operation(token);

            return DeserializeResults<T>(resultStream);
        }
    }
}
