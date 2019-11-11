using System;

namespace ConsoleProject
{
    /// <summary>
    /// 测试C#7.0中函数返回多个值的问题
    /// </summary>
    static class BackValueTuple
    {
        public static void GetPerInfo()
        {
            var perinfo = PerInfo();
            string name = perinfo.Item1;
            int age = perinfo.Item2;

            Console.WriteLine($"Hello {name}, 年龄是：{age}");
        }
        public static (string ,int) PerInfo()
        {
            string name = "gamecc666";
            int age = 25;

            return (name,age);
        }
    }
}
