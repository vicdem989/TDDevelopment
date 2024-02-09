using System.Runtime.InteropServices;
using converter;

namespace program{
    using tests;

    class Program {
    public static double valueToConvert = 0;
    public static string desiredFormat = string.Empty;
        public static void Main(string[] args) {
            if(args.Length <= 1) {
                Console.WriteLine("Input number and format as a command line argument!");
                Environment.Exit(0); 
            }
                bool testing = false;
                for(int i = 0; i < args.Length; i++) {
                    if(args[i] == "-t") 
                        testing = true;
                }
                

                valueToConvert = double.Parse(args[0]);
                desiredFormat = args[1].Replace("-", "");

                
                double convertedValue = Converter.Convert(valueToConvert, desiredFormat);
                
                if(testing)
                    Tests.RunTests(testing, valueToConvert, desiredFormat);
            
                Console.WriteLine(valueToConvert + " inches is " + convertedValue + " " + desiredFormat);
                Console.WriteLine(testing);
        }
    }
}