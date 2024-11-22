using System.Text.RegularExpressions;

namespace Intranet.Interview.Share.Validators
{
    public static class EmailValidator
    {
        private static string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        public static bool IsValidEmail(this string email) => Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase);
    }
}
