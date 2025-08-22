

using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTest
{
    private const string InvalidUrl = "banana";
    private const string ValidUrl = "https://balta.io";

    [TestMethod]
    public void DadoUmaUrlInvalidDeveRetornarUmaExcecao()
    {
        try
        {
            var url = new Url(InvalidUrl);
            Assert.Fail();
        }
        catch (InvalidUrlException)
        {
            Assert.IsTrue(true);
        }
    }

    [TestMethod]
    public void DadoUmaUrlValidDeveRetornarOk()
    {
        new Url(ValidUrl);
        Assert.IsTrue(true);
    }

    [TestMethod]
    [DataRow("", true)]
    [DataRow("http", true)]
    [DataRow("banana", true)]
    [DataRow("https://balta.io", false)]
    public void TestUrl(string link, bool expectException)
    {
        if (expectException)
        {
            try
            {
                new Url(link);
                Assert.Fail();
            }
            catch (InvalidUrlException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
