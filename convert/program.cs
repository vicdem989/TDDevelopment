using System.Runtime.InteropServices;
using converter;

namespace program{
    using tests;

    class Program {
        public static void Main(string[] args) {
            if(args.Length < 2 || args.Length > 3) {
                Console.WriteLine("Input number and format as a command line argument!");
                Environment.Exit(0); 
            }
            bool testing = false;
            for(int i = 0; i < args.Length; i++) {
                if(args[i] == "-t") 
                    testing = true;
            }
                
            double valueToConvert = double.Parse(args[0]);
            string desiredFormat = args[1].Replace("-", "");
            
            double convertedValue = Converter.Convert(valueToConvert, desiredFormat);
                
            if(testing)
                Tests.RunTests(testing, valueToConvert, desiredFormat);
            
            Console.WriteLine(valueToConvert + " inches is " + convertedValue + " " + desiredFormat);
        }
    }
}