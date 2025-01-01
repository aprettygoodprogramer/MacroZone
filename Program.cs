using System;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0 || args[0] == "--help" || args[0] == "-h")
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("--help or -h: Show this menu");
            return;
        }

    }
}