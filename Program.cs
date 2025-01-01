using System;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0 || args[0] == "--help" || args[0] == "-h")
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("--help or -h: Show this menu");
        }
        string filePath = "C:\\Users\\evanj\\test.txt";

        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            //Console.WriteLine("File Content:");
            //Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine($"The file {filePath} does not exist.");
        }
    }

}
