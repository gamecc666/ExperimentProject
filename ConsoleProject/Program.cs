﻿using System;


namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BackValueTuple.GetPerInfo();               //测试C#7.0元组
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm"));

            Console.WriteLine("***************测试结束***************");
            Console.ReadKey();
        }       
    }
}