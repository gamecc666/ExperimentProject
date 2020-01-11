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
            //格式化数据、包含保留小数
            DataFormat.FormatInfo();
            //测试循环索引
            //Recyle.TestCycle();
            //测试父字符串包含子字符串
            //StringContains.IsStringHasSubstring();
            //string path = @"D:\ZYAPPXmlData\BackData";
            //GetFileNames.GetFilesName(path);            
            Console.WriteLine("*****************************************测试结束**********************************************");

            //string[] atr = new string[] { "1"};
            //atr = null;
            //Console.WriteLine(atr);
            Console.ReadKey();
        }     
    }
}
