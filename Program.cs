using System;
using static System.Net.Mime.MediaTypeNames;

public class Program
{

    public static void Main(string[] args)
    {
        if (args.Length == 0 || args[0] == "--help" || args[0] == "-h")
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("--help or -h: Show this menu");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("{path\\to\\file}: Will run the file");
        }

        else {

            string filePath = args[0];
            Console.WriteLine($"File Path: {filePath}");
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("File Content:");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine($"The file {filePath} does not exist.");
            }

        }

        Console.ReadLine();

    }

}
