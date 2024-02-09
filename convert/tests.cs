

namespace tests {
using program;
using converter;

    class Tests {
        public static void RunTests(bool testing, double valueToConvert, string desiredFormat) {
            if(testing) {
                Console.WriteLine("\x1b[1mTesting is not turned on\x1b[0m");
            }
            if(desiredFormat.Contains("-")) {
                Console.WriteLine("Test Failed -> Remove '-'");
            } else {
                Console.WriteLine("Passed Test! -> '-' has been removed");
            }

            string[] availableFormats = new string[] { "mm", "cm", "m"};
            bool correctFormat = false;
            for(int i = 0; i < availableFormats.Length; i++) {
                if(desiredFormat == availableFormats[i]) {
                    correctFormat = true;
                    break;
                } else 
                    correctFormat = false;
            }
            if(correctFormat)
                Console.WriteLine("Passed Test! -> " + desiredFormat + " is a valid format.");
            else 
                Console.WriteLine("Test Failed -> " + desiredFormat + " is not a valid format!");
        }
    }
}