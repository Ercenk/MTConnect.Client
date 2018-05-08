using NUnit.Framework;

namespace Tests
{
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using Client;

    using MTConnect.Client;

    public class Tests
    {
        private IMTConnectClient client;

        [SetUp]
        public void Setup()
        {
            this.client = new MTConnectClient("https://smstestbed.nist.gov/vds");
        }

        [Test]
        public async Task Probe()
        {
            var result = await this.client.ProbeAsync();

            Assert.That(result.Devices, Is.Not.Empty);
        }

        [Test]
        public async Task Current()
        {
            var result = await this.client.CurrentAsync();

            Assert.That(result.Streams, Is.Not.Empty);
        }

        [Test]
        public async Task Sample()
        {
            var result = await this.client.SampleAsync();

            Assert.That(result.Streams, Is.Not.Empty);
        }

        [Test]
        public async Task ProbeOne()
        {
            var all = await this.client.ProbeAsync();

            var first = await this.client.ProbeAsync(all.Devices.First().id);

            Assert.That(first.Devices, Has.One.Items);
        }

        [Test]
        public async Task SampleOne()
        {
            var all = await this.client.ProbeAsync();

            var first = await this.client.SampleAsync(all.Devices.First().id);

            Assert.That(first.Streams, Has.One.Items);
        }

        [Test]
        public async Task CurrentOne()
        {
            var all = await this.client.ProbeAsync();

            var first = await this.client.CurrentAsync(all.Devices.First().id);

            Assert.That(first.Streams, Has.One.Items);
        }
    }
}