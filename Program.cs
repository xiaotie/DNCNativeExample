using System;

namespace DotNetNative
{
    class Program
    {
        static void Main(string[] args)
        {
            new GenericsTest<Int32>().Test(32);
        }
    }
}
