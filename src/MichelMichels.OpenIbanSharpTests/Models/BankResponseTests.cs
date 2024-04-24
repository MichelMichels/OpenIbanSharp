using MichelMichels.OpenIbanSharp.Models;

namespace MichelMichels.OpenIbanSharpTests.Models;

[TestClass]
public class BankResponseTests
{
    [TestMethod]
    public void DefaultValues()
    {
        // Arrange
        BankResponse response = new();

        // Act

        // Assert
        Assert.AreEqual(false, response.IsValid);
        Assert.IsNotNull(response.Messages);
        Assert.AreEqual(string.Empty, response.IBAN);
        Assert.IsNotNull(response.BankData);
        Assert.IsNotNull(response.Results);
    }
}
