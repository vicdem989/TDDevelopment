namespace convert;

public class Convert {
    public static void Main(string[] args) {
        if(args.Length <= 1) {

            /// Have to verify that args[0] == number and args[1] == string (mm, cm or m)

            Console.WriteLine("Input number and format as a command line argument!");
            Environment.Exit(0); /// Allow for multiple retries instead of crashing program if possible
            }

                

    }
}