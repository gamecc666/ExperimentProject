using ConsoleProject.interfacelib;
using System;


namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************开始测试**********************************************");

            //C#7.0元组，返回多个值
            //BackValueTuple.GetPerInfo();
            //设置日期格式
            //Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm"));
            //测试循环索引
            //Recyle.TestCycle();
            //测试父字符串包含子字符串
            //StringContains.IsStringHasSubstring();
            //string path = @"D:\ZYAPPXmlData\BackData";
            //GetFileNames.GetFilesName(path);
            double a = 5.35;
            double b = 6.354;
            var res = a / b;
            Console.WriteLine($"输出运算结果：{res.ToString("#0.0000")}");
            Console.WriteLine("*****************************************测试结束**********************************************");

            //string[] atr = new string[] { "1"};
            //atr = null;
            //Console.WriteLine(atr);
            Console.ReadKey();
        }     
    }
}
