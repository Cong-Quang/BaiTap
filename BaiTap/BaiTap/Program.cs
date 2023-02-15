using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;

namespace BaiTap
{
    class Program
    {
        static int targetFps = 120;
        static int positionX = 0;
        static int positionY = 0;
        static Stopwatch stopwatch = new Stopwatch();
        static double targetFrameTime = 1.0 / targetFps;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Data.AddHomeWork();
            while (true)
            {
                stopwatch.Restart();

                SystemFPS();

                double elapsedTime = stopwatch.Elapsed.TotalSeconds;
                double sleepTime = targetFrameTime - elapsedTime;
                if (sleepTime > 0)
                {
                    System.Threading.Thread.Sleep((int)(sleepTime * 1000));
                }
            }
        }
        static void SystemFPS()
        {
            DrawFrame(10);
        }
        static void DrawFrame(int length)
        {
            for (int i = 0; i < length; i++)
            {
                for (int t = 0; t < length; t++)
                {
                    Console.WriteLine(Printf("1", i, t));
                }
            }
        }
        static string Printf(string s, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            return s;
        }
        static string Printf(string s, int x, int y,ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            return s;
        }
    }
    class Data
    {
        public static string[] Language = { "English", "Việt Nam" };
        public static List<string[]> List_HomeWork = new List<string[]>();
        public static void AddHomeWork()
        {
            List_HomeWork.Add(new string[]{ "*","/"});
        }
    }
}
