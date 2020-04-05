using System;

namespace CheckIdentifier
{	    
    public static class Program
    {   

		const string NoAnswer = "No";
    	const string YesAnswer = "Yes";  
    	
    	public static bool IsLatinLetter(char ch)
        {
            if ((ch >= 'A') && (ch <= 'Z') || (ch >= 'a') && (ch <= 'z'))
            {
                return true;
            }
            return false;
        }
    	        
		public static bool IsLatinLettersOrDigit(string input)
        {
	        foreach (char ch in input)
	            {
	                if (!IsLatinLetter(ch) && !char.IsDigit(ch))
	                {
	                    return false;
	                }
	            }
	        	return true;
		}
        
        public static bool CheckIdentifier(string input)
        {
            if (!IsLatinLettersOrDigit(input.Substring(1)))
            {
                System.Console.WriteLine(NoAnswer);
                System.Console.WriteLine("Identifier must include only Latin letters or digits(not the first character)");
                return false;
            }
            if (!IsLatinLetter(input[0]))
            {
                System.Console.WriteLine(NoAnswer);
                System.Console.WriteLine("Identifier must begin with a letter");
                return false;
            }
            if (input == "")
            {
                System.Console.WriteLine(NoAnswer);
                System.Console.WriteLine("Empty identifier");
                return false;
            }
            System.Console.WriteLine(YesAnswer);
            return true;
        }

        public static bool TakeArgs(string[] args, ref string input)
        {
            if (args.Length != 1)
            {
                System.Console.WriteLine(NoAnswer);
                System.Console.WriteLine("Incorrect number of arguments!\nUsage CheckIdentifier.exe <input string>" );
                return false;
            }
            input = args[0];
            return true;
        }

        
        public static int Main(string[] args)
        {
            string input = "";
            if (!TakeArgs(args, ref input))
            {
                return 1;
            }
            CheckIdentifier(input);
            

            return 0;
        }
    }
}