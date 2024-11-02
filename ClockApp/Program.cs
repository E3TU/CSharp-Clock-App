// using System;
// using System.Threading;
using Spectre.Console;
// using Spectre.Console.Cli;

namespace ClockApp
{
    class ClockApp
    {
        static void Main(string[] args)
        {
            // Clear the scrollback buffer
            string hidecursor = "\\e[3J";
            // Clear the console
            Console.Clear();
            
            while (true)
            {
                DateTime now = DateTime.Now;
                
                string time24h = now.ToString("HH:mm:ss");
                
                // Console.SetCursorPosition(0, 0);
                // Console.WriteLine(time24h);
                var figlet = new FigletText(time24h).Centered().Color(Color.Green);

                AnsiConsole.Live(figlet)
                    .AutoClear(true)   // Do not remove when done
                    .Start(ctx =>
                    {   
                        ctx.Refresh();
                        Thread.Sleep(1000);
                        Console.Write(hidecursor);
                    });
            }
        }
    }
}
