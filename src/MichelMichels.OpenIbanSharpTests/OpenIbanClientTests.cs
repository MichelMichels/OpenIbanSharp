using MichelMichels.OpenIbanSharp;
using MichelMichels.OpenIbanSharp.Models;

namespace MichelMichels.OpenIbanSharpTests;

[TestClass]
public class OpenIbanClientTests
{
    [TestMethod()]
    public void Constructor_BaseUrl_ArgumentNullReferenceException()
    {
        Assert.Throws<ArgumentNullException>(() => new OpenIbanClient(null!));
    }

    [TestMethod]
    public async Task Validate_IBAN_Null()
    {
        // Arrange
        OpenIbanClient client = new("https://example.com");

        // Act
        Task task = client.Validate(null!);

        // Assert
        await Assert.ThrowsAsync<ArgumentNullException>(() => task);
    }

    [TestMethod]
    public async Task Validate_IBAN_Valid()
    {
        // Arrange
        string testIban = "BE41063012345610";
        OpenIbanClient client = new(@"https://openiban.com/");

        // Act
        BankResponse response = await client.Validate(testIban);

        // Assert
        Assert.AreEqual(true, response.IsValid);
        Assert.AreEqual("063", response.BankData["bankCode"]);
        Assert.AreEqual("BELFIUS BANK", response.BankData["name"]);
        Assert.AreEqual("GKCCBEBB", response.BankData["bic"]);
    }
}