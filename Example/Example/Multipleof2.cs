using System;

namespace Example
{
    class Multipleof2
    {
        public static void Multiple()
        { 
        Console.WriteLine("Enter which tables has been printed");
        int a = Convert.ToInt32(Console.ReadLine());
        int b;
        for(int i=1;i<=10;i++)
            {
              b=i*a;
              Console.WriteLine(i + "* "+a+" = "+b );
            }
    }
}

}
