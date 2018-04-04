using NUnit.Framework;

namespace Tests
{
    using System.IO;
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
        public async Task Test1()
        {
            var result = await this.client.ProbeAsync();

            var result1 = await this.client.CurrentAsync();
            
            Assert.Pass();
        }
    }
}