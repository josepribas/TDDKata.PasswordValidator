using FluentAssertions;

namespace TDDKata.PasswordValidator.Tests;

public class PasswordValidatorTests
{
    [Fact]
    public void Valid_Password_Should_Return_True()
    {
        PasswordValidator.Validate("1234ABCabc__").Should().Be(true);
    }
    
    [Fact]
    public void Password_Without_A_Number_Returns_False() {
        PasswordValidator.Validate("ABCabc__").Should().Be(false);
    }
}