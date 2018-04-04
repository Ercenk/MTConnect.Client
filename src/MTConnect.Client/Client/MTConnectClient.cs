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
        private MTConnectAdapter adapterClient;

        public MTConnectClient(string baseUri)
        {
            this.adapterClient = new MTConnectAdapter(new Uri(baseUri));
        }

        public async Task<MTConnectDevicesType> ProbeAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var resultStream = await this.adapterClient.ProbeAsync(cancellationToken);

            return DeserializeResults<MTConnectDevicesType>(resultStream);
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

        public async Task<MTConnectStreamsType> CurrentAsync(
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var resultStream = await this.adapterClient.CurrentAsync(cancellationToken);

            return DeserializeResults<MTConnectStreamsType>(resultStream);
        }
    }
}
