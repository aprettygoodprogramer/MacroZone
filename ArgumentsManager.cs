namespace MacroZone
{
    class ArgumentsManager
    {
        public string[] args { get; set; }

        public ArgumentsManager(string[] Arg)
        {
            this.args = Arg;
        }

        public void DisplayHelp()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("--help or -h: Show this menu");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("{path\\to\\file}: Run the file");
        }
    }
}   