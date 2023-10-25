using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordCheckDemo
{
    internal class PasswordValidator : IPasswordValidator
    {
        public bool IsStrongPassword(string password)
        {

            if (password.Length < 8)
                return false;


            int uppercaseCount = Regex.Matches(password, @"[A-Z]").Count;
            if (uppercaseCount < 2)
                return false;


            int lowercaseCount = Regex.Matches(password, @"[a-z]").Count;
            if (lowercaseCount < 2)
                return false;


            int digitCount = Regex.Matches(password, @"[0-9]").Count;
            if (digitCount < 2)
                return false;


            if (!Regex.IsMatch(password, @"[!@#\$%\^&\*\(\)_\+=\-\[\]\{\};:'<>,./\\?|~]"))
                return false;


            return true;
        }
    }
}
