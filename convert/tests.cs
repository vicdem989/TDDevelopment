

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
            } 
        }
    }
}