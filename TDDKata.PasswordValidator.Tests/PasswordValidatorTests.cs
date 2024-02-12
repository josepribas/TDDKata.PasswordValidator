namespace TDDKata.PasswordValidator.Tests;

public class PasswordValidatorTests
{
    [Fact]
    public void ValidPassword_Should_Return_True()
    {
        PasswordValidator.Validate("1234ABCabc__").Should().Be(true);
    }
}