using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace MacroZone
{
    class MacroReader
    {
        public string FilePath { get; set; }
        private string[] lines;

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        private const int KEYEVENTF_KEYDOWN = 0x0000; 
        private const int KEYEVENTF_KEYUP = 0x0002;   

        public MacroReader(string path)
        {
            this.FilePath = path;
        }

        public void ReadFile()
        {
            if (File.Exists(FilePath))
            {
                lines = File.ReadAllLines(FilePath);
                Console.WriteLine("File loaded successfully!");
            }
            else
            {
                Console.WriteLine($"Error: The file '{FilePath}' does not exist.");
            }
        }

        public void MakeInstructions()
        {
            if (lines == null || lines.Length == 0)
            {
                Console.WriteLine("No file content loaded. Please call ReadFile() first.");
                return;
            }

            foreach (var line in lines)
            {
                if (line.StartsWith("macro:keypress:"))
                {
                    var key = line.Replace("macro:keypress:", "").Trim();
                    if (key.Length == 1 && char.IsLetterOrDigit(key[0]))
                    {
                        PressKey(key[0]);
                        Console.WriteLine($"Simulated keypress for: {key[0]}");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid key instruction: {key}");
                    }
                }
                else if (line.StartsWith("macro:sleep:"))
                {
                    var sleepTimeStr = line.Replace("macro:sleep:", "").Trim();
                    if (int.TryParse(sleepTimeStr, out int sleepTime))
                    {
                        Console.WriteLine($"Sleeping for {sleepTime} milliseconds...");
                        Thread.Sleep(sleepTime); 
                    }
                    else
                    {
                        Console.WriteLine($"Invalid sleep duration: {sleepTimeStr}");
                    }
                }
                else
                {
                    Console.WriteLine($"Unknown instruction: {line}");
                }
                foreach (var key in keypressLines)
            {
                if (key.Length == 1 && char.IsLetterOrDigit(key[0]))
                {
                    PressKey(key[0]);
                    
                    Console.WriteLine($"Simulated keypress for: {key[0]}");
                }
                else
                {
                    Console.WriteLine($"Invalid key instruction: {key}");
                }
            }
        }

        private void PressKey(char key)
        {
            byte virtualKeyCode = (byte)char.ToUpper(key); 
            keybd_event(virtualKeyCode, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(virtualKeyCode, 0, KEYEVENTF_KEYUP, 0);
        }
    }
}
