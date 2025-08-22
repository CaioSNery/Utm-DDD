using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class CampaignTest
{
    [TestMethod]
    [DataRow("", "", "", true)]
    [DataRow("src", "", "", true)]
    [DataRow("", "med", "", true)]
    [DataRow("", "", "nme", true)]
    [DataRow("src", "med", "nam", true)]
    public void TestCampaign(string source, string medium, string name, bool expectedException)
    {
        if (expectedException)
        {
            try
            {
                new Campaign(source, medium, name);
                Assert.Fail();
            }
            catch (InvalidCampaignException)

            {

                Assert.IsTrue(true);
            }
        }
        else
        {
            new Campaign(source, medium, name);
            Assert.IsTrue(true);
        }
    }
}
