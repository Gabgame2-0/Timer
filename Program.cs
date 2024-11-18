using System;

namespace Timer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.CursorVisible = false;
            bool playing = true;
            int hour = 0;
            int minute = 0;
            int second = 0;
            while (playing)
            {
                //code begging
                Console.WriteLine("00:00:00     Press enter to start !");
                ConsoleKeyInfo touch = Console.ReadKey(intercept: true);
                if (touch.Key == ConsoleKey.Enter)
                { }
                else if (touch.Key == ConsoleKey.RightArrow)
                { }

                playing = false;
            }
        }
    }
}
