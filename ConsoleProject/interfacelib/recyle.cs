using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.interfacelib
{
    public static class Recyle
    {
        public static void TestCycle()
        {
            string[] arr = new string[] { "asdfs", "afsad", "afas", "saf" };
            foreach(string item in arr)
            {
                var index = Array.IndexOf(arr, item);
                Console.WriteLine("索引：" + index);
            }
        }
    }
}
