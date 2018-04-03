using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    using System.Threading;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Serialization;

    using MTConnect.Client;

    public class MTConnectClient : IMTConnectClient
    {
        public async Task<MTConnectDevicesType> ProbeAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var adapterClient = new MTConnectAdapter();
            var resultStream = await adapterClient.ProbeAsync(cancellationToken);

            MTConnectDevicesType result;
            using (var reader = XmlReader.Create(resultStream))
            {
                var serializer = new XmlSerializer(typeof(MTConnectDevicesType));
                result = (MTConnectDevicesType)serializer.Deserialize(reader);
            }

            return result;
        }
    }
}
