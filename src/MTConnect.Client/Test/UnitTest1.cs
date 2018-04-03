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
            this.client = new MTConnectClient();
        }

        [Test]
        public async Task Test1()
        {
            var result = await this.client.ProbeAsync();
            
            Assert.Pass();
        }
    }
}