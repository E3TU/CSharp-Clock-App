using System;
using System.Threading;

namespace ClockApp
{
    class ClockApp
    {
        static void Main(string[] args)
        {
            Console.Title = "ClockApp";
            
            Console.Clear();
            Console.CursorVisible = false;
            
            while (true)
            {
                DateTime now = DateTime.Now;
                
                string time24h = now.ToString("HH:mm:ss");
                
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(time24h);
                Thread.Sleep(1000);
            }
            
        }
    }
}
