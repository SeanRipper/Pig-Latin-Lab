using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Pig_Latin_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn)
            {
                Console.WriteLine("Please enter a word");
                string input = Console.ReadLine().ToLower();
                string pig = pigLatin(input);

                if (pig == "-1")
                {
                    Console.WriteLine("Pig latin requires a vowel.");
                }
                else
                {
                    Console.WriteLine(pig);
                }
                bool tryAgain = true;
                while (tryAgain)
                {

                    Console.WriteLine("Try again? Y/N");
                    string reply = Console.ReadLine().ToLower();
                    if (reply == "y" || reply == "yes")
                    {
                        goOn = true;
                        tryAgain = false;
                    }
                    else if (reply == "n" || reply == "no")
                    {
                        Console.WriteLine("Goodbye.");
                        goOn = false;
                        tryAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter y or n");
                        tryAgain = true;
                    }
                }
            }
        }
        public static bool checkVowel(char l)
        {
            return (l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u');
        }
        public static string pigLatin(string word)
        {
            int length = word.Length;
            int index = -1;

            if (checkVowel(word[0]))
            {
                return (word + "way");
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    if (checkVowel(word[i]))
                    {
                        index = i;
                        break;
                    }
                }
            }
            if (index == -1)
                return "-1";
            return word.Substring(index) + word.Substring(0, index) + "ay";
        }
    }
}