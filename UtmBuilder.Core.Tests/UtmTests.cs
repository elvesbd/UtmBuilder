using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests;

[TestClass]
public class UtmTests
{
    [TestMethod]
    public void ShouldReturnUrlFromUtm()
    {
        var url = new Url("https://balta.io/");
        var campaign = new Campaign
        (
            "src",
            "med",
            "nme",
            "id",
            "ter",
            "ctn"
        );
        var utm = new Utm(url, campaign);

        var result = "https://balta.io/?utm_source=src&utm_medium=med&utm_name=nme&utm_id=id&utm_term=ter&utm_content=ctn";
        Assert.AreEqual(result, utm.ToString());
    }
}