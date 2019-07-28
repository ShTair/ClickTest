using System;
using System.Threading.Tasks;

namespace ClickTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(RunAsync);
            Console.ReadLine();
        }

        private static async Task RunAsync()
        {
            while (true)
            {
                Mouse.Click(-250, 880);
                await Task.Delay(2000);

                Mouse.Click(-350, 860);
                await Task.Delay(1000);
            }
        }
    }
}
