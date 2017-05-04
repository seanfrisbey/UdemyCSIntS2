using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            var cont = true;

            while (cont)
            {
                Console.WriteLine("Enter \"start\", \"stop\", \"duration\", or \"end\" --->");
                var inputString = Console.ReadLine();
                
                switch (inputString)
                {
                    case "start":
                        stopwatch.Start();
                        break;
                    case "stop":
                        stopwatch.Stop();
                        break;
                    case "duration":
                        Console.WriteLine(stopwatch.GetDuration().ToString());
                        break;
                    default:
                        cont = false;
                        break;
                }
            }
        }
    }
}