using System;

namespace Timer
{
    public class Program
    {
        public static int highlighter = -2;
        public static int second = 0;
        public static int minute = 0;
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            bool playing = true;
            bool choice = true;
            while (playing)
            {

                Console.CursorVisible = false;




                Console.WriteLine(@"00:00     Press ""Enter"" to start or ""Escape"" to quit!");
                while (choice)
                {
                    //code begging
                    
                    ConsoleKeyInfo touch = Console.ReadKey(intercept: true);
                    //manage input
                    if (touch.Key == ConsoleKey.Enter)
                    { }
                    else if (touch.Key == ConsoleKey.RightArrow)
                    {
                        highlighter += 2;
                    }
                    else if (touch.Key == ConsoleKey.LeftArrow)
                    {
                        highlighter -= 2;
                    }
                    else if (touch.Key == ConsoleKey.Escape)
                    {
                        choice = false;
                        playing = false;
                    }
                    ChoosingTimer();
                    Console.WriteLine(@"    Press ""Enter"" to start or ""Escape"" to quit!");

                }
                playing = false;
            }

        }

        public static void ChoosingTimer()
        {
            Console.Clear();
            if (highlighter == 0)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                if (9 < minute)
                    Console.Write(minute);
                else
                    Console.Write("0" + minute);
                Console.BackgroundColor = ConsoleColor.Black;
                if (9 < second)
                    Console.Write(":" + second);
                else
                    Console.Write(":0" + second);

            }
            else
            {
                if (9 < minute)
                    Console.Write(minute + ":");
                else
                    Console.Write("0" + minute + ":");
                Console.BackgroundColor = ConsoleColor.Blue;
                if (9 < second)
                    Console.Write(second);
                else
                    Console.Write("0" + second);
                Console.BackgroundColor = ConsoleColor.Black;


            }

        }
    }
}
