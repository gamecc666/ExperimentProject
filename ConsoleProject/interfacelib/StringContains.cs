using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.interfacelib
{
    public static class StringContains
    {
        public static void IsStringHasSubstring()
        {
            string parString = "a:劝说文";
            string subString = "劝说文";

            Console.WriteLine($"父字符串是否包含子字符串：{parString.Contains(subString)}");
        }
    }
}

