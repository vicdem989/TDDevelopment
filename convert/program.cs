using System.Runtime.InteropServices;
using converter;

public class Program {

    public static void Main(string[] args) {
        if(args.Length <= 1) {

            /// Have to verify that args[0] == number and args[1] == string (mm, cm or m)

            Console.WriteLine("Input number and format as a command line argument!");
            Environment.Exit(0); /// Allow for multiple retries instead of crashing program if possible
        }

            double valueToConvert = double.Parse(args[0]);
            string desiredFormat = args[1].Replace("-", "");
            
            double convertedValue = Converter.Convert(valueToConvert, desiredFormat);
        
            Console.WriteLine(valueToConvert + " inches is " + convertedValue + " " + desiredFormat);
    }
}
