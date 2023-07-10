using System;

namespace Example
{
    class Swapping
    {
        public static void swap()
        {
            int a, b;
            Console.WriteLine("Enter the two number to be Swapped");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            a = a * b;
            b = a / b;
            a = a / b;
            Console.Write("Numbers after swapped ");
            Console.WriteLine(a +","+b);
        }
    }
}
