using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroZone
{



    class MacroReader
    {
        string filePath { get; set; }
        string[] lines;
        string[] instructions;
        public MacroReader(string path)
        {
            this.filePath = path;
        }
        public void readFile()
        {

            if (File.Exists(filePath))
            {
                lines = (File.ReadAllLines(filePath));
                Console.WriteLine("File loaded successfully!");
            }
            else
            {
                Console.WriteLine($"Error: The file '{filePath}' does not exist.");
            }

        }
        public void Makeinstructions()
        {
            instructions = lines.Where(line => line.StartsWith("macro")).ToArray();
            foreach (var instruction in instructions)
            {
                Console.WriteLine(instruction);
            }
        }
    }

}