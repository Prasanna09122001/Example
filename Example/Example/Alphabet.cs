using System;

namespace Example
{
    class Alphabet
    {
        public static void AlphabetorVowel()
        {
            Console.WriteLine("Enter the Alphabet");
            char a=Console.ReadLine();
            if(a =="a" ||  a =="e" || a=="i" || a=="o" || a=="u" || a=="A" || a=="E" || a=="I" || a=="O" || a=="U")
            {
                Console.WriteLine("It is a Vowel");
            }
            else { Console.WriteLine("It is a Consonant");
            }
        }
    }
}
