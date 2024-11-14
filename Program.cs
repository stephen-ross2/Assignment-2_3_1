using System.ComponentModel.Design;
using System.Diagnostics;

namespace Assignment_2_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\rosss\source\repos\Assignment 2_3_1\bin\Debug\net8.0\UserInfo.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            File.WriteAllLines(filePath, lines);

            Console.ReadLine();

        }
    }
}


           

