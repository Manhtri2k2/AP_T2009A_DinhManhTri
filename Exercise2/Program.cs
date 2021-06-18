using System;

namespace Exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string strWord;
            string word;
            int strt = 0;
            int cnt = -1;
            int idx = -1;

            Console.WriteLine("Enter a string");
            strWord = Console.ReadLine();
            Console.WriteLine("Enter a word to search: ");
            word = Console.ReadLine();


            while (strt != -1)
            {
                strt = strWord.IndexOf(word, idx + 1);
                cnt += 1;
                idx = strt;
            }

            Console.Write($"Word found {cnt} times in the string", word);

            Console.ReadKey();
        }
    }
}