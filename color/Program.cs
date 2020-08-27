using System;
using System.Diagnostics;

namespace color
{
    class Program
    {
        static void Main(string[] args)
        {

            //Gets color code
            string color = "0f";

            if (args.Length != 0)
            {
                
                //Checks if there are only 2 characters
                if (args[0].Length != 2)
                {
                    Console.WriteLine("Invalid colorcode");
                }

                //Checks if color code is valid
                if (!"0123456789abcdef".Contains(args[0].ToLower()[0].ToString()) || !"0123456789abcdef".Contains(args[0].ToLower()[0].ToString()))
                {
                    Console.WriteLine("Invalid colorcode");
                }

                //Sets color code
                color = args[0];

            }

            //Sends color code to cmd.exe
            ProcessStartInfo pi = new ProcessStartInfo("cmd.exe", "/C \"color " + color + "\"");
            pi.UseShellExecute = false;

            //Contains until EOP
            try
            {
                var p = Process.Start(pi);
                p.WaitForExit();
                p.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to Execute: " + e.Message);
            }


        }
    }
}
