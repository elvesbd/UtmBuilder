using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests;

[TestClass]
public class CampaignTests
{
    private const string InvalidUrl = "invalid_url";
    private const string ValidUrl = "https://balta.io";

    [TestMethod]
    [DataRow("", "", "", true)]
    [DataRow("source", "", "", true)]
    [DataRow("source", "medium", "", true)]
    [DataRow("source", "medium", "name", false)]
    public void TestCampaign(
        string source,
        string medium,
        string name,
        bool expectException
    )
    {
        if (expectException)
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