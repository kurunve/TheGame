using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixReader
{
    class Program
    {
        private static List<string> possibleParameters = new List<string>() {"-i", "-o"}; 
        static void Main(string[] args)
        {
            string inputfileName = "input.txt";
            string outputFileName = "output.txt";
            string[] inputParametrs = Environment.GetCommandLineArgs();
            Console.WriteLine("Look!");
            bool isParamCorrect = isParametersOfCommandLineCorrect(inputParametrs);
            
            //foreach(string s in inputParametrs)
            //    Console.WriteLine(s);
            if (isParamCorrect)
            {
                if (inputParametrs.Length > 1)
                {
                    int temp = -1;
                    if (IsConsist(inputParametrs, "-i", out temp))
                        inputfileName = inputParametrs[temp + 1];
                    if (IsConsist(inputParametrs, "-o", out temp))
                        outputFileName = inputParametrs[temp + 1];
                }

                Console.WriteLine("Hello, Vova!");
                Console.WriteLine("Input file name: {0}", inputfileName);
                Console.WriteLine("Output file name: {0}", outputFileName);
            }
            else
            {
                Console.WriteLine("Invalid format");
            }
            Console.ReadKey();
        }

        private static bool IsConsist<T>(IEnumerable<T> source, T item, out int position ) where T: IComparable
        {
            position = -1;
            int counter = 0;
            foreach (T elem in source)
            {
                if (elem.CompareTo(item) == 0 )
                {
                    position = counter;
                    return true;
                }
                counter++;
            }

            return false;
        }

        private static bool isParametersOfCommandLineCorrect(string[] parameters)
        {
            int temp = -1;
            for (int i = 0; i < parameters.Length-1; ++i)
            {
                if (IsConsist(possibleParameters, parameters[i], out temp) && IsConsist(possibleParameters, parameters[i + 1], out temp))
                    return false;
            }
            return true;
        }
    }
}
