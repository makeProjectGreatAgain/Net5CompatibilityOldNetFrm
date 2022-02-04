using System;

namespace NetCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm NetCoreConsoleApp");

            NetStandard20Lib.NetStandard20Lib.Test();
            NetFramework40.NetFramework40.Test();
            NetFramework20.NetFramework20.Test();

            // no errors, no warns =(
            NetFramework40.NetFramework40.CallUnSupportedApi();
        }
    }
}
