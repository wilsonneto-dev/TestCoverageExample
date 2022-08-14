using FluentAssertions;

namespace Lib.UnitTests;

public class UserTests
{
    [Fact]
    public void Instantiate()
    {
        var expectedName = "New User";
        var expectedEmail = "example@email.com";
        var expectedHashPassword = "hashedpasswrd";
        
        var user = new User(expectedName, expectedEmail, expectedHashPassword);
        
        user.Should().NotBeNull();
    }
}
