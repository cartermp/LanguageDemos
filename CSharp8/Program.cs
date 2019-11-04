using System;
using System.Threading.Tasks;

namespace CSharp8
{
    class Program
    {
        public static void DoDIMs()
        {
            Console.WriteLine("Showing off DIMs!...");
            Console.WriteLine("--------------------------------");

            IDeveloper csharpDev = new AverageDotNetDeveloper();
            csharpDev.SayIdentity();

            IDeveloper fsharpDev = new FSharpDeveloper();
            fsharpDev.SayIdentity();

            Console.WriteLine("--------------------------------");
        }

        public static async Task DoAsyncStreams()
        {
            Console.WriteLine("Showing off async streams!");
            Console.WriteLine("--------------------------------");

            // Note the 'await' here. This is required.
            await foreach (var number in AsyncStreams.GenerateSequence())
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("--------------------------------");
        }

        public static void DoIndexAndRange()
        {
            Console.WriteLine("Showing off async streams!");
            Console.WriteLine("--------------------------------");

            IndexAndRange.Demo();

            Console.WriteLine("--------------------------------");
        }

        static async Task Main(string[] args)
        {
            DoDIMs();
            await DoAsyncStreams();
            DoIndexAndRange();
        }
    }
}
