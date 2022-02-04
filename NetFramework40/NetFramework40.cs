using System;

namespace NetFramework40
{
    public class NetFramework40
    {
        public static void Test() => Console.WriteLine("I'm NetFramework40");
        public static void CallUnSupportedApi() {
            // unsupported API
            string s = AppDomain.CurrentDomain.ApplicationIdentity.FullName;
            Console.WriteLine(s);
        }
    }
}
