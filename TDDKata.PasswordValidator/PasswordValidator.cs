namespace TDDKata.PasswordValidator;

public static class PasswordValidator
{
    public static bool Validate(string password) {

        if (!password.Any(char.IsDigit))
            return false;

        return true;
    }
}
