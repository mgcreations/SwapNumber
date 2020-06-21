using System;

/// <summary>
/// Write a C# Sharp program to swap two numbers. The user enters 2 numbers which are swapped.
/// Test Data:
/// Input the First Number : 5
/// Input the Second Number : 6
/// Expected Output:
/// After Swapping :
/// First Number : 6
/// Second Number : 5
/// </summary>

namespace SwapNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;

            Console.Write("Enter first number \t:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number \t:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Swapping Numbers:");
            Console.WriteLine("Before Swap \n num1 : {0} , num2 : {1}", num1, num2);

            temp = num2;
            num2 = num1;
            num1 = temp;

            Console.WriteLine("After swap \n num1 : {0} , num2 : {1}", num1, num2);
        }
    }
}
