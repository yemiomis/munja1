using System;

namespace munja
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n3 = 5;
            Console.Write("Please enter an integer number n3 for printTriangle method: ");
            // This variable will gather data from user input
            string input3 = Console.ReadLine();
            // This variable will be used to perform some iterations and is parsed as an integer
            int input_value3 = int.Parse(input3);
            printTriangle(input_value3);
            Console.Write("\n");
        }
        private static void printTriangle(int num)
        {

        }
    }
}


