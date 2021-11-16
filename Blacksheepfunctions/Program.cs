using System;
using System.IO;

namespace Blacksheepfunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is a Chuck Norris joke!");
            Console.WriteLine(GetRandomJoke());
            
        }
        static string GetRandomJoke()
        {
            string filePath = @"C:\Users\Laptop\samples\Chuck_Norris_Jokes.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string chuckJoke = dataFromFile[GetRandomNumber(dataFromFile.Length)];
            return chuckJoke;
        }
        static int GetRandomNumber(int someint)
        {
            Random rnd = new Random();
            return rnd.Next(0, someint);
        }

    }
}
