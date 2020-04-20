using System;

namespace ConsoleProject.interfacelib
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
            string sex = perinfo.Item3;
            Console.WriteLine($"方式1 {name}, 年龄是：{age},性别是：{sex}");
            var perinfo2 = PerInfo2();
            string name2 = perinfo2.name;
            int age2 = perinfo2.age;
            string sex2 = perinfo2.sex;
            Console.WriteLine($"方式2 {name2}, 年龄是：{age2},性别是：{sex2}");
        }
        public static (string ,int,string) PerInfo()
        {
            string name = "gamecc666";
            int age = 25;
            string sex = "男";
            return (name,age,sex);
        }
        public static (string name, int age, string sex) PerInfo2()
        {
            string name = "gamecc666";
            int age = 25;
            string sex = "男";
            return (name, age, sex);
        }
    }
}
