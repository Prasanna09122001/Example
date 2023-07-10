using System;

namespace Example
{
    class program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter what program has to be executed\n1.Multiple Table\n2.Alphabet or Vowel\n3.Swapping of Numbers");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1: Multipleof2.Multiple();
                        break;
                    case 2:
                        Alphabet.AlphabetorVowel();
                        break;
                    case 3:
                        Swapping.swap();
                        break;
                    case 4: 
                        Add.add();
                        break;
                } 
            }
        }
    }
}