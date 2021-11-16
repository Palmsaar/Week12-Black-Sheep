using System;
using System.IO;

namespace FruitsAndVegetables
{
    class Program
    {
        static void Main(string[] args)
        {
            string veggePath = @"C:\Users\Laptop\samples\Veggie.txt";
            string fruitPath = @"C:\Users\Laptop\samples\Fruit.txt";
            string[] fruitData = File.ReadAllLines(veggePath);
            string[] veggeData = File.ReadAllLines(fruitPath);
            File.WriteAllLines(fruitPath, fruitData);
            File.WriteAllLines(veggePath, veggeData);
        }
    }
}
