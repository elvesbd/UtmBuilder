using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests;

[TestClass]
public class UrlTests
{
    private const string InvalidUrl = "invalid_url";
    private const string ValidUrl = "https://balta.io";

    [TestMethod]
    [ExpectedException(typeof(InvalidUrlException))]
    public void ShouldReturnExceptionWhenUrlIsNull()
    {
        var url = new Url(null);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidUrlException))]
    public void ShouldReturnExceptionWhenUrlIsInvalid()
    {
        var url = new Url(InvalidUrl);
    }

    [TestMethod]
    public void ShouldNotReturnExceptionWhenUrlIsValid()
    {
        var url = new Url(ValidUrl);
        Assert.IsTrue(true);
    }
}