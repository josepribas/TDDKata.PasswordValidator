namespace TDDKata.PasswordValidator;

public static class PasswordValidator
{
    public static bool Validate(string password) {

        if (!password.Any(char.IsDigit))
            return false;

        if (!password.Any(char.IsUpper))
            return false;

        if (!password.Contains('_'))
            return false;

        if (password.Length < 8)
            return false;

        return true;
    }
}
