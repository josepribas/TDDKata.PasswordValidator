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

    [Fact]
    public void Password_Without_An_Uppercase_Returns_False() {
        PasswordValidator.Validate("1234abc__").Should().Be(false);
    }

    [Fact]
    public void Password_Without_An_Lowercase_Returns_False() {
        PasswordValidator.Validate("1234ABC__").Should().Be(false);
    }

    [Fact]
    public void Password_Without_An_Undescore_Returns_False() {
        PasswordValidator.Validate("1234ABCabc").Should().Be(false);
    }

    [Fact]
    public void Password_With_Less_Than_8_Characters_Returns_False() {
        PasswordValidator.Validate("1Aa_").Should().Be(false);
    }
}
