using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RemoveExtraBlanks
{
    public class Program
    {
    	public static bool ParseArgs(string[] args, string inputName, string outputName)
        {
            if (args.Length != 2)
            {
                System.Console.WriteLine("Incorrect number of arguments!\nUsage RemoveExtraBlanks.exe <input file name> <output file name>");
                return false;
            }
        inputName = args[0];
        outputName = args[1];
        return true;
        }

        public static bool ProcessData(string line, string inputFileName, string outputFileName)
        {
            if (!File.Exists(inputFileName))
            {
                Console.WriteLine("File doesn't exist");
                return false;
            }

            StreamReader inputFile = new StreamReader(inputFileName);
            StreamWriter outputFile = new StreamWriter(outputFileName);

            while ((line = inputFile.ReadLine()) != null)
            {
                outputFile.WriteLine(RemoveExtraBlanks(line));
            }

            inputFile.Close();
            outputFile.Close();
            return true;
        }
      
        public static string RemoveExtraBlanks(string line)
        {
            line = line.Trim();
            Regex regexText = new Regex(@"[ , \t]+");
            return regexText.Replace(line, " ");
        }
        
        static int Main(string[] args)
        {
            if (!ParseArgs(args, inputName, outputName))
            {
                return 1;
            }

            if (!ProcessData(line, inputName, outputName))
            {
                return 1;
            }

            return 0;
        }       
    }
}