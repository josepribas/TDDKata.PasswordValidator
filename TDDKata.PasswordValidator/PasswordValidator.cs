using System.Text.RegularExpressions;

namespace TDDKata.PasswordValidator;

public static class PasswordValidator
{
    public static bool Validate(string password) {

        Regex validatePasswordRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[_]).{8,}$");
        return validatePasswordRegex.IsMatch(password); 

    }
}
