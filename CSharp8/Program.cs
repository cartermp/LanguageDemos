using System;

namespace CSharp8
{
    class Program
    {
        public static void DoDIMs()
        {
            IDeveloper csharpDev = new AverageDotNetDeveloper();
            csharpDev.SayIdentity();


            IDeveloper fsharpDev = new FSharpDeveloper();
            fsharpDev.SayIdentity();
        }
        static void Main(string[] args)
        {
            DoDIMs();
        }
    }
}
