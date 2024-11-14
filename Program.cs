using System.ComponentModel.Design;
using System.Diagnostics;

namespace Assignment_2_3__
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"C:\Users\rosss\source\repos\Assignment 2_3_!\bin\Debug\net8.0\UserInfo.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            File.WriteAllLines(filePath, lines);

            Console.ReadLine();


           /* string filePath = "UserInfo.txt";

            using (StreamWriter writer = new StreamWriter(filePath))

            {
                writer.WriteLine("Name: Steve Ross");
                writer.WriteLine("Age: 34");
                writer.WriteLine("Location: Shalimar, FL");

            }

            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine($"The file is saved in: {currentDirectory}\\{filePath}");

            if (File.Exists(filePath))
            {
                Console.WriteLine("Reading details from the file:");
                using (StreamReader reader = new StreamReader(filePath))

                {
                    string line;
                    while ((line = reader.ReadLine()) != null)

                    {
                        Console.WriteLine(line);
                    }
                }
            }

            else
            {
                Console.WriteLine("File not found");
                            } */
        }
    }
}
