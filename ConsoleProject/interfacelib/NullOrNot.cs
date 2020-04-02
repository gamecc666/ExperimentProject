using System;

namespace ConsoleProject.interfacelib
{
    static class NullOrNot
    {
        public static void NullableUse()
        {
            //int? num1 = null;   //注意不能使用string?=null 因为str是可为空的
            int? num1 = 2;           
            if (num1.HasValue)
            {
                Console.WriteLine($"num1是有值的！{num1.Value}");
            }
            else
            {
                Console.WriteLine("num1是没有值的");
            }
            int num2 = num1 ?? 5;
            Console.WriteLine($"num2的值是{num2}");
        }
    }
}
