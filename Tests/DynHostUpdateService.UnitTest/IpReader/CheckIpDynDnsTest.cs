using DynHost.IpReader.CheckIpDynDns;
using NFluent;
using NUnit.Framework;

namespace DynHostUpdateService.UnitTest.IpReader
{
    /// <summary>
    /// Summary description for DynHost
    /// </summary>
    [TestFixture]
    public class CheckIpDynDnsTest
    {
        [Test]
        public void CheckGetIpReturnNoEmptyString()
        {
            var ipReader = new CheckIpDynDns();
            Check.That(ipReader.GetCurrentIp()).IsNotNull().And.IsNotEmpty();
        }
    }
}
