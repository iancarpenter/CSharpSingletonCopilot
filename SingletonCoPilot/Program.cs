// provide an example of a singleton class
// ensure the code is easy to test
// ensure the code is commented
namespace SingletonCoPilot
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new instance of the singleton class
            SingletonCoPilot2 singletonCoPilot = SingletonCoPilot2.GetInstance();

            SingletonCoPilot2 singletonCoPilot2 = SingletonCoPilot2.GetInstance();

            // call the method to print the message
            singletonCoPilot.PrintMessage("Hey there! I'm first!");
            singletonCoPilot2.PrintMessage("Hey there! I'm second!");

            Console.WriteLine(singletonCoPilot == singletonCoPilot2);

        }
    }

    public class SingletonCoPilot2
    {
        // create a private static instance of the class
        private static SingletonCoPilot2? instance;

        // create a private constructor
        private SingletonCoPilot2() { }

        // create a public static method to get the instance of the class
        public static SingletonCoPilot2 GetInstance()
        {
            // check if the instance is null
            if (instance == null)
            {
                // create a new instance of the class
                instance = new SingletonCoPilot2();
            }

            // return the instance
            return instance;
        }

        // create a public method to print a message
        public void PrintMessage(string message)
        {
            // print the message
            Console.WriteLine(message);
        }
    }
}