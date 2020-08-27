using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cd
{
    public class BetterDll
    {

        public BetterDll(string args)
        {

            //If no args, returns current directory
            if (args == "")
            {
                Console.WriteLine(Environment.CurrentDirectory);
                return;
            }

            //If args, appends to path or sets path
            else if (args.Length > 2 && args[1] == ':')
            {

                if (Directory.Exists(args))
                {

                    Environment.CurrentDirectory = args;
                    return;

                } else
                {

                    Console.WriteLine("Could not find file: '{0}'", args);
                    return;

                }

            }

            //Local cd forwards
            else if (Directory.Exists(Environment.CurrentDirectory + Path.DirectorySeparatorChar + args))
            {

                Environment.CurrentDirectory = Environment.CurrentDirectory + Path.DirectorySeparatorChar + args;

            }

            //Cd backwards
            else if (args == "..")
            {

                try
                {

                    var d = Directory.GetParent(Environment.CurrentDirectory);
                    Environment.CurrentDirectory = d.FullName;

                } catch (Exception e)
                {

                    Console.WriteLine("Failed to CD backwards: " + e.Message);

                }

            }

        }

    }
}
