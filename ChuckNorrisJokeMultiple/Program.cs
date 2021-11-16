using System;
using System.IO;
using System.Collections.Generic;


namespace ChuckNorrisJokeMultiple

{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("How many Chuck Norris jokes do you want? (1 is min and 10 max)");
            int jokeAmount = Convert.ToInt32(Console.ReadLine());
            if (jokeAmount > 10)
            {
                jokeAmount = 10;
            }
            for (int i = 0; i < jokeAmount; i++)
            {
                Console.WriteLine(GetRandomJoke(numbers));
            }
        }
        static string GetRandomJoke(List<int> somelist)
        {
            Random rnd2 = new Random(); 
            string filePath = @"C:\Users\Laptop\samples\Chuck_Norris_Jokes.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
           
            if (somelist.Count == 0) 
            {
                for (int i = 0; i < dataFromFile.Length; i++)
                {
                    somelist.Add(i);
                }
            }

            
            int rndNum2 = rnd2.Next(0, somelist.Count);
            int rndToUse = somelist[rndNum2];
            somelist.Remove(somelist[rndNum2]);


           
           
            string chuckJoke = dataFromFile[rndToUse];
            return chuckJoke;
        }
        //static int GetRandomNumber(int someint)
        //{
        //    Random rnd = new Random();
        //    return rnd.Next(0, someint);
        //}
      
    }
}
