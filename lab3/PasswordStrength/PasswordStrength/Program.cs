using System;
using System.Linq;


namespace PasswordStrength
{
    public class Program
    {   	
        public static int CalculateSecurityByLenght(string password)
        {
            return 4 * password.Length;
        }
        
        public static int CalculateSecurityByNumbersTotal(string password)
        {
            int count = password.Count(char.IsDigit).Count();
            return count *= 4;
        }

         public static int CalculateSecurityByUpperCaseLettersTotal(string password)
        {
            var count = 0;
            int upperLetterCount = password.Count(char.IsUpper);
            if (upperLetterCount != 0)
            {
                return (count - upperLetterCount) * 2;
            }
            return 0;
        }

        public static int CalculateSecurityByLowerCaseLettersTotal(string password)
        {
            var count = 0;
            int lowerLetterCount = password.Count(char.IsLower);
            if (lowerLetterCount != 0)
            {
                return (count - lowerLetterCount) * 2;
            }
            return 0;
        }
        
        public static int CalculateSecurityByOnlyLetters(string password)
        {
            var count = password.Count(char.IsLetter);
            if (count == password.Length)
            {
                return -count;
            }
            return 0;
        }
        
        public static int CalculateSecurityByOnlyDigits(string password)
        {
            var count = 0;
            int lowerLetterCount = password.Count(char.IsDigit);
            if (lowerLetterCount == password.Length)
            {
                return -count;
            }
            return 0;
        }
        
        public static int CalculateSecurityByReapetedSymbols(string password)
        {
            var result = 0;
            var count = 0;
            char prevCh = '\0';
            foreach (var letter in password.Distinct().ToArray())
            {
                count = password.Count(chr => chr == letter);
                if (count != 1)
                {
                    result += count;
                }
            }
            return -result;
        }
        
        public static int PasswordStrength(string password)
        {
            int passwordStrenght = 0;
            passwordStrenght += CalculateSecurityByLenght(password);
            passwordStrenght += CalculateSecurityByNumbersTotal(password);
            passwordStrenght += CalculateSecurityByUpperCaseLettersTotal(password);
            passwordStrenght += CalculateSecurityByLowerCaseLettersTotal(password);
            passwordStrenght += CalculateSecurityByOnlyLetters(password);
            passwordStrenght += CalculateSecurityByOnlyDigits(password);
            passwordStrenght += CalculateSecurityByReapetedSymbols(password);
            return passwordStrenght;
        }
    
        public static bool ParseArg(string args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Incorrect number of arguments\nUsage: PasswordStrength.exe <input password>");
                return false;
            }
            return true;
        }
        
        static int Main(string args)
        {
            if (!ParseArg(args))
            {
                return 1;
            }
            int passwordStrenght = PasswordStrength(args);
            Console.WriteLine(passwordStrenght);
            return 0;
        }
    }
}