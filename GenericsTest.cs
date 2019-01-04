using System;

namespace DotNetNative
{
    /// <summary>
    /// 泛型测试
    /// </summary>
    class GenericsTest<T> where T : struct
    {
        public void Test(T t)
        {
            Console.WriteLine(t.ToString());
        }
    }
}
