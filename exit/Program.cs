using System;

namespace exit
{
    class BetterDll
    {
        
        public BetterDll(string args)
        {
            Console.WriteLine("EXITING: " + args);
            Environment.Exit(0);
        }

    }
}
