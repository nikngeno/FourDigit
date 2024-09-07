using System;

namespace FourDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a four digit number - example 6734: ");
            int fourDigit = int.Parse(Console.ReadLine());

            int firstDig = fourDigit % 10;
            int secondDig = (fourDigit / 10) % 10;
            int thirdDig = (fourDigit / 100) % 10;
            int fourDig = (fourDigit / 1000) % 10;

            //Console.WriteLine(fourDigit);
            Console.WriteLine(firstDig);
            Console.WriteLine(secondDig);
            Console.WriteLine(thirdDig);
            Console.WriteLine(fourDig);
            

            Console.WriteLine("The Sum of the digits is: " + (firstDig + secondDig + thirdDig + fourDig));
        }
    }
}
