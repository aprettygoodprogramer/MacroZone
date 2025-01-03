using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    private static List<string> lines;

    public static void Main(string[] args)
    {
        var argumentManager = new MacroZone.ArgumentsManager(args);
        var macroReader = new MacroZone.MacroReader(args[0]);

        if (args.Length == 0 || args[0] is "--help" or "-h")
        {
            argumentManager.DisplayHelp();
            return;
        }

        macroReader.readFile();
        macroReader.Makeinstructions();
    }

    private static void DisplayFileContent()
    {
        if (lines != null && lines.Count > 0)
        {
            Console.WriteLine("File Content:");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("No content to display.");
        }
    }
}
